﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Data.Excel;
using EggLink.DanhengServer.Enums.Scene;
using EggLink.DanhengServer.Game.Scene.Entity;
using EggLink.DanhengServer.Server.Packet.Send.Scene;
using EggLink.DanhengServer.Util;

namespace EggLink.DanhengServer.Game.Scene
{
    public class SceneEntityLoader(SceneInstance scene)
    {
        public SceneInstance Scene { get; set; } = scene;

        public virtual void LoadEntity()
        {
            if (Scene.IsLoaded) return;

            foreach (var group in Scene?.FloorInfo?.Groups.Values!)  // Sanity check in SceneInstance
            {
                if (group.LoadSide == GroupLoadSideEnum.Client)
                {
                    continue;
                }
                if (group.GroupName.Contains("TrainVisitor"))
                {
                    continue;
                }
                LoadGroup(group);
            }
            Scene.IsLoaded = true;
        }

        public void SyncEntity()
        {
            bool refreshed = false;
            var oldGroupId = new List<int>();
            foreach (var entity in Scene.Entities.Values)
            {
                if (!oldGroupId.Contains(entity.GroupID))
                    oldGroupId.Add(entity.GroupID);
            }

            var removeList = new List<IGameEntity>();
            var addList = new List<IGameEntity>();

            foreach (var group in Scene.FloorInfo!.Groups.Values)
            {
                if (group.LoadSide == GroupLoadSideEnum.Client)
                {
                    continue;
                }

                if (group.GroupName.Contains("TrainVisitor"))
                {
                    continue;
                }

                if (oldGroupId.Contains(group.Id))  // check if it should be unloaded
                {
                    if (group.UnloadCondition.IsTrue(Scene.Player.MissionManager!.Data, false) || group.ForceUnloadCondition.IsTrue(Scene.Player.MissionManager!.Data, false))
                    {
                        foreach (var entity in Scene.Entities.Values)
                        {
                            if (entity.GroupID == group.Id)
                            {
                                Scene.RemoveEntity(entity);
                                removeList.Add(entity);
                                refreshed = true;
                            }
                        }
                    }
                } else  // check if it should be loaded
                {
                    var groupList = LoadGroup(group);
                    refreshed = groupList != null || refreshed;
                    addList.AddRange(groupList ?? []);
                }
            }
            if (refreshed)
            {
                Scene.Player.SendPacket(new PacketSceneGroupRefreshScNotify(addList, removeList));
            }
        }

        public virtual List<IGameEntity>? LoadGroup(GroupInfo info)
        {
            var missionData = Scene.Player.MissionManager!.Data;
            if (!info.LoadCondition.IsTrue(missionData) || info.UnloadCondition.IsTrue(missionData, false) || info.ForceUnloadCondition.IsTrue(missionData, false))
            {
                return null;
            }
            var entityList = new List<IGameEntity>();
            foreach (var npc in info.NPCList)
            {
                try
                {
                    if (LoadNpc(npc, info) is EntityNpc entity)
                    {
                        entityList.Add(entity);
                    }
                } catch{ }
            }

            foreach (var monster in info.MonsterList)
            {
                try
                {
                    if (LoadMonster(monster, info) is EntityMonster entity)
                    {
                        entityList.Add(entity);
                    }
                } 
                catch { }
            }

            foreach (var prop in info.PropList)
            {
                try
                {
                    if (LoadProp(prop, info) is EntityProp entity)
                    {
                        entityList.Add(entity);
                    }
                } catch { }
            }

            return entityList;
        }

        public virtual EntityNpc? LoadNpc(NpcInfo info, GroupInfo group, bool sendPacket = false)
        {
            if (info.IsClientOnly || info.IsDelete)
            {
                return null;
            }
            if (!GameData.NpcDataData.ContainsKey(info.NPCID))
            {
                return null;
            }
            bool hasDuplicateNpcId = false;
            foreach (IGameEntity entity in Scene.Entities.Values)
            {
                if (entity is EntityNpc eNpc && eNpc.NpcId == info.NPCID)
                {
                    hasDuplicateNpcId = true;
                    break;
                }
            }
            if (hasDuplicateNpcId)
            {
                return null;
            }
            EntityNpc npc = new(Scene, group, info);
            Scene.AddEntity(npc, sendPacket);

            return npc;
        }

        public virtual EntityMonster? LoadMonster(MonsterInfo info, GroupInfo group, bool sendPacket = false)
        {
            if (info.IsClientOnly || info.IsDelete)
            {
                return null;
            }

            GameData.NpcMonsterDataData.TryGetValue(info.NPCMonsterID, out var excel);
            if (excel == null)
            {
                return null;
            }

            EntityMonster entity = new(Scene, info.ToPositionProto(), info.ToRotationProto(), group.Id, info.ID, excel, info);
            Scene.AddEntity(entity, sendPacket);
            return entity;
        }

        public virtual EntityProp? LoadProp(PropInfo info, GroupInfo group, bool sendPacket = false)
        {
            if (info.IsClientOnly || info.IsDelete)
            {
                return null;
            }

            GameData.MazePropData.TryGetValue(info.PropID, out var excel);
            if (excel == null)
            {
                return null;
            }

            var prop = new EntityProp(Scene, excel, group, info);

            if (prop.PropInfo.PropID == 1003)
            {
                if (prop.PropInfo.MappingInfoID == 2220)
                {
                    prop.SetState(PropStateEnum.Open);
                    Scene.AddEntity(prop, sendPacket);
                }
            } else
            {
                Scene.AddEntity(prop, sendPacket);
            }
            if (excel.PropType == PropTypeEnum.PROP_SPRING)
            {
                Scene.HealingSprings.Add(prop);
                prop.SetState(PropStateEnum.CheckPointEnable);
            }

            // load from database
            var propData = Scene.Player.GetScenePropData(Scene.FloorId, group.Id, info.ID);
            if (propData != null)
            {
                prop.SetState(propData.State);
            } 
            else
            {
                prop.SetState(info.State);
                //if (excel.PropStateList.Contains(PropStateEnum.Closed) && info.State == PropStateEnum.Locked)
                //{
                //    prop.SetState(PropStateEnum.Closed);
                //}
            }
            return prop;
        }
    }
}
