using EggLink.DanhengServer.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Scene
{
    [Opcode(CmdIds.LeaveRaidCsReq)]
    public class HandlerLeaveRaidCsReq : Handler
    {
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {
            var player = connection.Player!;
            if (player.CurRaidId == 0)
            {
                connection.SendPacket(CmdIds.LeaveRaidScRsp);
                return;
            }

            player.CurRaidId = 0;
            player.EnterScene(player.OldEntryId, 0, true);
            player.MoveTo(player.LastPos!, player.LastRot!);
            player.OldEntryId = 0;
            player.LastPos = null;
            player.LastRot = null;
            connection.SendPacket(CmdIds.LeaveRaidScRsp);
        }
    }
}
