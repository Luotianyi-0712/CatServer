﻿namespace EggLink.DanhengServer.Data.Excel
{
    [ResourceEntity("AvatarConfig.json", true)]
    internal class AvatarConfigExcel : ExcelResource
    {
        public int AvatarID { get; set; } = 0;

        public override int GetId()
        {
            return AvatarID;
        }

        public override void Loaded()
        {
            GameData.AvatarConfigData.Add(AvatarID, this);
        }
    }
}
