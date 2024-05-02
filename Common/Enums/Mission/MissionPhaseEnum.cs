﻿using EggLink.DanhengServer.Proto;

namespace EggLink.DanhengServer.Enums
{
    public enum MissionPhaseEnum
    {
        Doing = 0,
        Finish = 1,
        Cancel = 2,
        None = 3,
    }

    public static class MissionStatusExtensions
    {
        public static MissionStatus ToProto(this MissionPhaseEnum status)
        {
            return status switch
            {
                MissionPhaseEnum.None => MissionStatus.MissionNone,
                MissionPhaseEnum.Doing => MissionStatus.MissionDoing,
                MissionPhaseEnum.Finish => MissionStatus.MissionFinish,
                MissionPhaseEnum.Cancel => MissionStatus.MissionNone,
                _ => MissionStatus.MissionNone,
            };
        }
    }
}
