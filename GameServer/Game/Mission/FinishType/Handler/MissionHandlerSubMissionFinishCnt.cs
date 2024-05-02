﻿using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Game.Player;

namespace EggLink.DanhengServer.Game.Mission.FinishType.Handler
{
    [MissionFinishType(MissionFinishTypeEnum.SubMissionFinishCnt)]
    public class MissionHandlerSubMissionFinishCnt : MissionFinishTypeHandler
    {
        public override void Init(PlayerInstance player, SubMissionInfo info, object? arg)
        {
            // Do nothing
        }

        public override void HandleFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
        {
            var finish = info.Operation == OperationEnum.And;
            foreach (var missionId in info.ParamIntList)
            {
                var status = player.MissionManager!.GetSubMissionStatus(missionId);
                if (status != MissionPhaseEnum.Finish && status != MissionPhaseEnum.Cancel)
                {
                    if (info.Operation == OperationEnum.And)
                    {
                        finish = false;
                        break;
                    }
                } else
                {
                    if (info.Operation == OperationEnum.Or)
                    {
                        finish = true;
                        break;
                    }
                }
            }
            if (finish)
            {
                player.MissionManager!.FinishSubMission(info.ID);
            }
        }
    }
}
