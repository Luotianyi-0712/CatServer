﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Server.Packet.Send.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Scene
{
    [Opcode(CmdIds.StartRaidCsReq)]
    public class HandlerStartRaidCsReq : Handler
    {
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {
            var req = StartRaidCsReq.Parser.ParseFrom(data);
            var player = connection.Player!;
            GameData.RaidConfigData.TryGetValue((int)(req.RaidId * 100 + req.WorldLevel), out var raidConfig);
            if (raidConfig != null)
            {
                player.OldEntryId = player.Data.EntryId;
                player.CurRaidId = raidConfig.RaidID;
                player.LastPos = player.Data.Pos;
                player.LastRot = player.Data.Rot;

                raidConfig.MainMissionIDList.ForEach(missionId =>
                {
                    player.MissionManager!.ReAcceptMainMission(missionId);
                });

                var entranceId = 0;
                if (raidConfig.RaidID == 1)
                {
                    // set
                    entranceId = 2013301;
                } else
                {
                    entranceId = raidConfig.RaidID;
                }
                player.EnterScene(entranceId, 0, true);
                connection.SendPacket(new PacketRaidInfoNotify((uint)raidConfig.RaidID));
            }
            connection.SendPacket(CmdIds.StartRaidScRsp);
        }
    }
}
