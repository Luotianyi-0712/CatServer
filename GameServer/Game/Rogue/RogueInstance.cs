﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Data.Excel;
using EggLink.DanhengServer.Game.Battle;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.Game.Rogue.Buff;
using EggLink.DanhengServer.Game.Rogue.Scene;
using EggLink.DanhengServer.Game.Rogue.Miracle;
using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Util;
using EggLink.DanhengServer.Server.Packet.Send.Rogue;
using EggLink.DanhengServer.Server.Packet.Send.Scene;
using EggLink.DanhengServer.Game.Rogue.Event;
using EggLink.DanhengServer.Game.Scene.Entity;
using EggLink.DanhengServer.Game.Rogue.Scene.Entity;

namespace EggLink.DanhengServer.Game.Rogue
{
    public class RogueInstance
    {
        #region Properties

        public PlayerInstance Player { get; set; }
        public int RogueVersionId { get; set; } = 101;
        public RogueStatus Status { get; set; } = RogueStatus.Doing;
        public Database.Lineup.LineupInfo CurLineup { get; set; } = new();
        public int CurReviveCost { get; set; } = 80;
        public int CurRerollCost { get; set; } = 30;
        public int BaseRerollCount { get; set; } = 1;
        public int BaseRerollFreeCount { get; set; } = 0;
        public int CurReachedRoom { get; set; } = 0;
        public int CurMoney { get; set; } = 100;
        public int CurDestroyCount { get; set; } = 0;
        public int AeonId { get; set; } = 0;
        public bool IsWin { get; set; } = false;
        public List<RogueBuffInstance> RogueBuffs { get; set; } = [];
        public Dictionary<int, RogueMiracleInstance> RogueMiracles { get; set; } = [];

        public RogueAeonExcel AeonExcel { get; set; }
        public RogueAreaConfigExcel AreaExcel { get; set; }
        public Dictionary<int, RogueRoomInstance> RogueRooms { get; set; } = [];
        public RogueRoomInstance? CurRoom { get; set; }
        public int StartSiteId { get; set; } = 0;

        public SortedDictionary<int, RogueActionInstance> RogueActions { get; set; } = [];  // queue_position -> action
        public int CurActionQueuePosition { get; set; } = 0;
        public int CurEventUniqueID { get; set; } = 100;

        public int CurAeonBuffCount { get; set; } = 0;
        public int CurAeonEnhanceCount { get; set; } = 0;
        public bool AeonBuffPending { get; set; } = false;  // prevent multiple aeon buff

        public RogueEventManager EventManager { get; set; }

        #endregion

        #region Initialization

        public RogueInstance(RogueAreaConfigExcel areaExcel, RogueAeonExcel aeonExcel, PlayerInstance player)
        {
            AreaExcel = areaExcel;
            AeonExcel = aeonExcel;
            AeonId = aeonExcel.AeonID;
            Player = player;
            CurLineup = player.LineupManager!.GetCurLineup()!;

            foreach (var item in areaExcel.RogueMaps.Values)
            {
                RogueRooms.Add(item.SiteID, new(item));
                if (item.IsStart)
                {
                    StartSiteId = item.SiteID;
                }
            }

            // add bonus
            var action = new RogueActionInstance()
            {
                QueuePosition = CurActionQueuePosition,
            };
            action.SetBonus();

            RogueActions.Add(CurActionQueuePosition, action);

            EventManager = new(Player, this);
        }

        #endregion

        #region Buffs

        public void RollBuff(int amount)
        {
            if (CurRoom!.Excel.RogueRoomType == 6)
            {
                RollBuff(amount, 100003, 2);  // boss room
                RollMiracle(1);
            }
            else
            {
                RollBuff(amount, 100005);
            }
        }

        public void RollBuff(int amount, int buffGroupId, int buffHintType = 1)
        {
            var buffGroup = GameData.RogueBuffGroupData[buffGroupId];
            var buffList = buffGroup.BuffList;
            var actualBuffList = new List<RogueBuffExcel>();
            foreach (var buff in buffList)
            {
                if (!RogueBuffs.Exists(x => x.BuffExcel.MazeBuffID == buff.MazeBuffID))
                {
                    actualBuffList.Add(buff);
                }
            }

            if (actualBuffList.Count == 0)
            {
                return;  // no buffs to roll
            }

            for (int i = 0; i < amount; i++)
            {
                var menu = new RogueBuffSelectMenu(this)
                {
                    CurCount = i + 1,
                    TotalCount = amount,
                };
                menu.RollBuff(actualBuffList);
                menu.HintId = buffHintType;
                var action = menu.GetActionInstance();
                RogueActions.Add(action.QueuePosition, action);
            }

            UpdateMenu();
        }

        public RogueCommonActionResult? AddBuff(int buffId, int level = 1, RogueActionSource source = RogueActionSource.RogueCommonActionResultSourceTypeDialogue, RogueActionDisplayType displayType = RogueActionDisplayType.RogueCommonActionResultDisplayTypeSingle, bool updateMenu = true, bool notify = true)
        {
            if (RogueBuffs.Exists(x => x.BuffExcel.MazeBuffID == buffId))
            {
                return null;
            }
            GameData.RogueBuffData.TryGetValue(buffId * 100 + level, out var excel);
            if (excel == null) return null;
            if (CurAeonBuffCount > 0)  // check if aeon buff exists
            {
                if (excel.IsAeonBuff)
                {
                    return null;
                }
            }
            var buff = new RogueBuffInstance(buffId, level);
            RogueBuffs.Add(buff);
            var result = buff.ToResultProto(source);

            if (notify)
            {
                Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, result, displayType));
            }
            
            if (updateMenu)
            {
                UpdateMenu();
            }

            return result;
        }

        public void AddBuffList(List<RogueBuffExcel> excel)
        {
            List<RogueCommonActionResult> resultList = [];
            foreach (var buff in excel)
            {
                var res = AddBuff(buff.MazeBuffID, buff.MazeBuffLevel, displayType: RogueActionDisplayType.RogueCommonActionResultDisplayTypeMulti, updateMenu: false, notify:false);
                if (res != null)
                {
                    resultList.Add(res);
                }
            }

            Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, resultList, RogueActionDisplayType.RogueCommonActionResultDisplayTypeMulti));

            UpdateMenu();
        }

        public void EnhanceBuff(int buffId, RogueActionSource source = RogueActionSource.RogueCommonActionResultSourceTypeDialogue)
        {
            var buff = RogueBuffs.Find(x => x.BuffExcel.MazeBuffID == buffId);
            if (buff != null)
            {
                GameData.RogueBuffData.TryGetValue(buffId * 100 + buff.BuffLevel + 1, out var excel);  // make sure the next level exists
                if (excel != null)
                {
                    buff.BuffLevel++;
                    Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, buff.ToResultProto(source), RogueActionDisplayType.RogueCommonActionResultDisplayTypeSingle));
                }
            }
        }

        public List<RogueBuffInstance> GetRogueBuffInGroup(int groupId)
        {
            var group = GameData.RogueBuffGroupData[groupId];
            return RogueBuffs.FindAll(x => group.BuffList.Contains(x.BuffExcel));
        }

        public void HandleBuffSelect(int buffId)
        {
            if (RogueActions.Count == 0)
            {
                return;
            }

            var action = RogueActions.First().Value;
            if (action.RogueBuffSelectMenu != null)
            {
                var buff = action.RogueBuffSelectMenu.Buffs.Find(x => x.MazeBuffID == buffId);
                if (buff != null)  // check if buff is in the list
                {
                    if (RogueBuffs.Exists(x => x.BuffExcel.MazeBuffID == buffId))  // check if buff already exists
                    {
                        // enhance
                        EnhanceBuff(buffId, RogueActionSource.RogueCommonActionResultSourceTypeSelect);
                    }
                    else
                    {
                        var instance = new RogueBuffInstance(buff.MazeBuffID, buff.MazeBuffLevel);
                        RogueBuffs.Add(instance);
                        Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, instance.ToResultProto(RogueActionSource.RogueCommonActionResultSourceTypeSelect)));
                    }
                }
                RogueActions.Remove(action.QueuePosition);
                if (action.RogueBuffSelectMenu.IsAeonBuff)
                {
                    AeonBuffPending = false;  // aeon buff added
                }
            }

            UpdateMenu();

            Player.SendPacket(new PacketHandleRogueCommonPendingActionScRsp(action.QueuePosition, selectBuff: true));
        }

        public void HandleRerollBuff()
        {
            if (RogueActions.Count == 0)
            {
                return;
            }
            var action = RogueActions.First().Value;
            if (action.RogueBuffSelectMenu != null)
            {
                action.RogueBuffSelectMenu.RerollBuff();  // reroll
                Player.SendPacket(new PacketHandleRogueCommonPendingActionScRsp(RogueVersionId, menu: action.RogueBuffSelectMenu));
            }
        }

        public void AddAeonBuff()
        {
            if (AeonBuffPending) return;
            if (CurAeonBuffCount + CurAeonEnhanceCount >= 4)
            {
                // max aeon buff count
                return;
            }
            int curAeonBuffCount = 0;  // current path buff count
            int hintId = AeonId * 100 + 1;
            var enhanceData = GameData.RogueAeonEnhanceData[AeonId];
            var buffData = GameData.RogueAeonBuffData[AeonId];
            foreach (var buff in RogueBuffs)
            {
                if (buff.BuffExcel.RogueBuffType == AeonExcel.RogueBuffType)
                {
                    if (!buff.BuffExcel.IsAeonBuff)
                    {
                        curAeonBuffCount++;
                    }
                    else
                    {
                        hintId++;  // next hint
                        enhanceData.Remove(buff.BuffExcel);
                    }
                }
            }

            var needAeonBuffCount = (CurAeonBuffCount + CurAeonEnhanceCount) switch
            {
                0 => 3,
                1 => 6,
                2 => 10,
                3 => 14,
                _ => 100,
            };

            if (curAeonBuffCount >= needAeonBuffCount)
            {
                RogueBuffSelectMenu menu = new(this)
                {
                    QueueAppend = 2,
                    HintId = hintId,
                    RollMaxCount = 0,
                    RollFreeCount = 0,
                    IsAeonBuff = true,
                };
                if (CurAeonBuffCount < 1)
                {
                    CurAeonBuffCount++;
                    // add aeon buff
                    menu.RollBuff([buffData], 1);
                }
                else
                {
                    CurAeonEnhanceCount++;
                    // add enhance buff
                    menu.RollBuff(enhanceData, enhanceData.Count);
                }

                var action = menu.GetActionInstance();
                RogueActions.Add(action.QueuePosition, action);

                AeonBuffPending = true;
                UpdateMenu();
            }
        }

        #endregion

        #region Methods

        public void UpdateMenu()
        {
            if (RogueActions.Count > 0)
            {
                Player.SendPacket(new PacketSyncRogueCommonPendingActionScNotify(RogueActions.First().Value, RogueVersionId));
            }

            AddAeonBuff();  // check if aeon buff can be added
        }

        public RogueRoomInstance? EnterRoom(int siteId)
        {
            var prevRoom = CurRoom;
            if (prevRoom != null)
            {
                if (!prevRoom.NextSiteIds.Contains(siteId))
                {
                    return null;
                }
                prevRoom.Status = RogueRoomStatus.Finish;
                // send
                Player.SendPacket(new PacketSyncRogueMapRoomScNotify(prevRoom, AreaExcel.MapId));
            }

            // next room
            CurReachedRoom++;
            CurRoom = RogueRooms[siteId];
            CurRoom.Status = RogueRoomStatus.Play;

            Player.EnterScene(CurRoom.Excel.MapEntrance, 0, false);

            // move
            AnchorInfo? anchor = Player.SceneInstance!.FloorInfo?.GetAnchorInfo(CurRoom.Excel.GroupID, 1);
            if (anchor != null)
            {
                Player.Data.Pos = anchor.ToPositionProto();
                Player.Data.Rot = anchor.ToRotationProto();
            }

            // send
            Player.SendPacket(new PacketSyncRogueMapRoomScNotify(CurRoom, AreaExcel.MapId));

            // call event
            EventManager.OnNextRoom();
            foreach (var miracle in RogueMiracles.Values)
            {
                miracle.OnEnterNextRoom();
            }

            return CurRoom;
        }

        public void LeaveRogue()
        {
            Player.RogueManager!.RogueInstance = null;
            Player.EnterScene(801120102, 0, false);
            Player.LineupManager!.SetExtraLineup(ExtraLineupType.LineupNone, []);
        }

        public void QuitRogue()
        {
            Status = RogueStatus.Finish;
            Player.SendPacket(new PacketSyncRogueStatusScNotify(Status));
            Player.SendPacket(new PacketSyncRogueFinishScNotify(ToFinishInfo()));
        }

        public void HandleBonusSelect(int bonusId)
        {
            if (RogueActions.Count == 0)
            {
                return;
            }

            var action = RogueActions.First().Value;

            // TODO: handle bonus
            GameData.RogueBonusData.TryGetValue(bonusId, out var bonus);
            if (bonus != null)
            {
                TriggerEvent(null, bonus.BonusEvent);
            }

            RogueActions.Remove(action.QueuePosition);
            UpdateMenu();

            Player.SendPacket(new PacketHandleRogueCommonPendingActionScRsp(action.QueuePosition, selectBonus: true));
        }

        #endregion

        #region Miracles

        public void RollMiracle(int amount, int groupId = 10002)
        {
            GameData.RogueMiracleGroupData.TryGetValue(groupId, out var group);
            if (group == null) return;

            for (int i = 0; i < amount; i++)
            {
                var list = new List<int>();

                foreach (var miracle in group)
                {
                    if (RogueMiracles.ContainsKey(miracle))
                    {
                        continue;
                    }
                    list.Add(miracle);
                }

                if (list.Count == 0) return;

                var menu = new RogueMiracleSelectMenu(this);
                menu.RollMiracle(list);
                var action = menu.GetActionInstance();
                RogueActions.Add(action.QueuePosition, action);
            }

            UpdateMenu();
        }

        public void HandleMiracleSelect(uint miracleId)
        {
            if (RogueActions.Count == 0)
            {
                return;
            }

            var action = RogueActions.First().Value;
            if (action.RogueMiracleSelectMenu != null)
            {
                var miracle = action.RogueMiracleSelectMenu.Results.Find(x => x == miracleId);
                if (miracle != 0)
                {
                    AddMiracle((int)miracle);
                }
                RogueActions.Remove(action.QueuePosition);
            }

            UpdateMenu();

            Player.SendPacket(new PacketHandleRogueCommonPendingActionScRsp(action.QueuePosition, selectMiracle: true));
        }

        public void AddMiracle(int miracleId)
        {
            if (RogueMiracles.ContainsKey(miracleId))
            {
                return;
            }

            GameData.RogueMiracleData.TryGetValue(miracleId, out var excel);
            if (excel == null) return;

            var miracle = new RogueMiracleInstance(this, miracleId);
            RogueMiracles.Add(miracleId, miracle);
            Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, miracle.ToGetResult(), RogueActionDisplayType.RogueCommonActionResultDisplayTypeSingle));
        }

        #endregion

        #region Money


        public void CostMoney(int amount, RogueActionDisplayType displayType = RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone)
        {
            CurMoney -= amount;
            Player.SendPacket(new PacketSyncRogueVirtualItemScNotify(this));

            Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, new RogueCommonActionResult()
            {
                Source = RogueActionSource.RogueCommonActionResultSourceTypeDialogue,
                RogueAction = new()
                {
                    RemoveItemList = new()
                    {
                        Num = (uint)amount,
                        DisplayType = (uint)displayType + 1,
                    },
                },
            }, displayType));
        }

        public void GainMoney(int amount, int displayType = 2, RogueActionDisplayType display = RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone)
        {
            CurMoney += amount;
            Player.SendPacket(new PacketSyncRogueVirtualItemScNotify(this));
            Player.SendPacket(new PacketScenePlaneEventScNotify(new Database.Inventory.ItemData()
            {
                ItemId = 31,
                Count = amount,
            }));

            Player.SendPacket(new PacketSyncRogueCommonActionResultScNotify(RogueVersionId, new RogueCommonActionResult()
            {
                Source = RogueActionSource.RogueCommonActionResultSourceTypeDialogue,
                RogueAction = new()
                {
                    GetItemList = new()
                    {
                        Num = (uint)amount,
                        DisplayType = (uint)displayType,
                    },
                },
            }, display));
        }

        #endregion

        #region Events

        public void TriggerEvent(RogueEventInstance? rogueEvent, int eventId)
        {
            EventManager.TriggerEvent(rogueEvent, eventId);
        }

        public RogueEventInstance GenerateEvent(RogueNpc npc)
        {
            RogueNPCDialogueExcel? dialogue;
            do
            {
                dialogue = GameData.RogueNPCDialogueData.Values.ToList().RandomElement();
            } while (dialogue == null || !dialogue.CanUseInCommon());

            var instance = new RogueEventInstance(dialogue, npc, CurEventUniqueID++);
            EventManager.AddEvent(instance);

            return instance;
        }

        public void HandleSelectOption(int eventId, int entityId)
        {
            var entity = Player.SceneInstance!.Entities[entityId];
            if (entity is not RogueNpc npc)
            {
                return;
            }

            EventManager.SelectOption(npc.RogueEvent!, eventId);
        }

        public void HandleFinishDialogueGroup(int entityId)
        {
            Player.SceneInstance!.Entities.TryGetValue(entityId, out var entity);
            if (entity == null || entity is not RogueNpc npc)
            {
                return;
            }

            EventManager.FinishEvent(npc.RogueEvent!);
        }

        public void HandleNpcDisappear(int entityId)
        {
            Player.SceneInstance!.Entities.TryGetValue(entityId, out var entity);
            if (entity == null || entity is not RogueNpc npc)
            {
                return;
            }

            EventManager.NpcDisappear(npc.RogueEvent!);
        }

        #endregion

        #region Handlers

        public void OnBattleStart(BattleInstance battle)
        {
            foreach (var miracle in RogueMiracles.Values)
            {
                miracle.OnStartBattle(battle);
            }

            foreach (var buff in RogueBuffs)
            {
                buff.OnStartBattle(battle);
            }

            GameData.RogueMapData.TryGetValue(AreaExcel.MapId, out var mapData);
            if (mapData != null)
            {
                mapData.TryGetValue(CurRoom!.SiteId, out var mapInfo);
                if (mapInfo != null && mapInfo.LevelList.Count > 0)
                {
                    battle.CustomLevel = mapInfo.LevelList[0];
                }
            }
        }

        public void OnBattleEnd(BattleInstance battle, PVEBattleResultCsReq req)
        {
            if (req.EndStatus != BattleEndStatus.BattleEndWin)
            {
                // quit
                return;
            }

            foreach (var miracle in RogueMiracles.Values)
            {
                miracle.OnEndBattle(battle);
            }

            if (CurRoom!.NextSiteIds.Count == 0)
            {
                // last room
                IsWin = true;
                Player.SendPacket(new PacketSyncRogueExploreWinScNotify());
            } else
            {
                RollBuff(battle.Stages.Count);
                GainMoney(Random.Shared.Next(20, 60) * battle.Stages.Count);
            }
        }

        public void OnPropDestruct(EntityProp prop)
        {
            if (!prop.Excel.IsHpRecover && !prop.Excel.IsMpRecover)
            {
                // gain money
                GainMoney(Random.Shared.Next(20, 60));
            }

            CurDestroyCount++;
        }

        #endregion

        #region Serialization

        public RogueCurrentInfo ToProto()
        {
            var proto = new RogueCurrentInfo()
            {
                Status = Status,
                GameMiracleInfo = ToMiracleInfo(),
                RogueAeonInfo = ToAeonInfo(),
                RogueLineupInfo = ToLineupInfo(),
                RogueBuffInfo = ToBuffInfo(),
                RogueVirtualItem = ToVirtualItemInfo(),
                MapInfo = ToMapInfo(),
                ModuleInfo = new()
                {
                    ModuleIdList = { 1, 2, 3, 4, 5 },
                },
                IsWin = IsWin,
            };

            if (RogueActions.Count > 0)
            {
                proto.PendingAction = RogueActions.First().Value.ToProto();
            } else
            {
                proto.PendingAction = new();
            }

            return proto;
        }

        public GameMiracleInfo ToMiracleInfo()
        {
            var proto = new GameMiracleInfo()
            {
                GameMiracleInfo_ = new()
                {
                    MiracleList = { },  // for the client serialization
                }
            };

            foreach (var miracle in RogueMiracles.Values)
            {
                proto.GameMiracleInfo_.MiracleList.Add(miracle.ToProto());
            }

            return proto;
        }

        public GameAeonInfo ToAeonInfo()
        {
            return new()
            {
                AeonId = (uint)AeonId,
                IsUnlocked = AeonId != 0,
                UnlockedAeonEnhanceNum = (uint)(AeonId != 0 ? 3 : 0)
            };
        }

        public RogueLineupInfo ToLineupInfo()
        {
            var proto = new RogueLineupInfo();

            foreach (var avatar in CurLineup.BaseAvatars!)
            {
                proto.BaseAvatarIdList.Add((uint)avatar.BaseAvatarId);
            }

            proto.ReviveInfo = new()
            {
                ReviveCost = new()
                {
                    ItemList = {
                        new ItemCost() {
                            PileItem = new PileItem() {
                                ItemId = 31,
                                ItemNum = (uint)CurReviveCost
                            }
                        },
                    }
                }
            };

            return proto;
        }

        public RogueBuffInfo ToBuffInfo()
        {
            var proto = new RogueBuffInfo()
            {
                MazeBuffList = { }
            };

            foreach (var buff in RogueBuffs)
            {
                proto.MazeBuffList.Add(buff.ToProto());
            }

            return proto;
        }

        public RogueVirtualItem ToVirtualItemInfo()
        {
            return new()
            {
                RogueMoney = (uint)CurMoney,
            };
        }

        public RogueMapInfo ToMapInfo()
        {
            var proto = new RogueMapInfo()
            {
                CurSiteId = (uint)CurRoom!.SiteId,
                CurRoomId = (uint)CurRoom!.RoomId,
                AreaId = (uint)AreaExcel.RogueAreaID,
                MapId = (uint)AreaExcel.MapId,
            };

            foreach (var room in RogueRooms)
            {
                proto.RoomList.Add(room.Value.ToProto());
            }

            return proto;
        }

        public RogueBuffEnhanceInfo ToEnhanceInfo()
        {
            var proto = new RogueBuffEnhanceInfo();

            foreach (var buff in RogueBuffs)
            {
                proto.EnhanceInfo.Add(buff.ToEnhanceProto());
            }

            return proto;
        }

        public RogueFinishInfo ToFinishInfo()
        {
            AreaExcel.ScoreMap.TryGetValue(CurReachedRoom, out var score);
            var prev = Player.RogueManager!.ToRewardProto();
            Player.RogueManager!.AddRogueScore(score);
            var next = Player.RogueManager!.ToRewardProto();

            return new()
            {
                ScoreId = (uint)score,
                TotalScore = (uint)score,
                PrevRewardInfo = prev,
                NextRewardInfo = next,
                AreaId = (uint)AreaExcel.RogueAreaID,
                FinishedRoomCount = (uint)CurReachedRoom,
                ReachedRoomCount = (uint)CurReachedRoom,
                RecordInfo = new()
                {
                    Id = 2
                }
            };
        }

        #endregion
    }
}
