﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Data.Excel;
using EggLink.DanhengServer.Database;
using EggLink.DanhengServer.Database.Avatar;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.Server.Packet.Send.Player;
using EggLink.DanhengServer.Util;

namespace EggLink.DanhengServer.Game.Avatar
{
    public class AvatarManager : BasePlayerManager
    {
        public AvatarData AvatarData { get; private set; }

        public AvatarManager(PlayerInstance player) : base(player) 
        {
            AvatarData = DatabaseHelper.Instance!.GetInstanceOrCreateNew<AvatarData>(player.Uid);
            foreach (var avatar in AvatarData.Avatars)
            {
                avatar.PlayerData = player.Data;
                avatar.Excel = GameData.AvatarConfigData[avatar.AvatarId];
            }
        }

        public void AddAvatar(int avatarId)
        {
            GameData.AvatarConfigData.TryGetValue(avatarId, out AvatarConfigExcel? avatarExcel);
            if (avatarExcel == null)
            {
                return;
            }

            var avatar = new AvatarInfo(avatarExcel)
            {
                AvatarId = avatarId >= 8001 ? 8001 : avatarId,
                Level = 1,
                Timestamp = Extensions.GetUnixSec(),
                CurrentHp = 10000,
                CurrentSp = 0
            };

            if (avatarId >= 8001)
            {
                if (GetHero() != null) return;  // Only one hero
                avatar.HeroId = avatarId;
            }

            avatar.PlayerData = Player.Data;
            AvatarData.Avatars.Add(avatar);
            DatabaseHelper.Instance?.UpdateInstance(AvatarData);

            Player.SendPacket(new PacketPlayerSyncScNotify(avatar));
        }

        public AvatarInfo? GetAvatar(int baseAvatarId)
        {
            if (baseAvatarId > 8000) baseAvatarId = 8001;
            return AvatarData.Avatars.Find(avatar => avatar.AvatarId == baseAvatarId);
        }

        public AvatarInfo? GetHero()
        {
            return AvatarData.Avatars.Find(avatar => avatar.HeroId > 0);
        }
    }
}
