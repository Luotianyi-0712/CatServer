using System.Collections.Generic;
using System.Text;

namespace EggLink.DanhengServer.Command.Cmd
{
    [CommandInfo("mission", "Get the running missions or finish the mission", "/mission <finish [submissionId]>/<running>")]
    public class CommandMission : ICommand
    {
        [CommandMethod("0 pass")]
        public void PassRunningMission(CommandArg arg)
        {
            if (arg.Target == null)
            {
                arg.SendMsg("Player not found.");
                return;
            }
            var mission = arg.Target!.Player!.MissionManager!;
            mission.GetRunningSubMissionIdList().ForEach(mission.FinishSubMission);
            arg.SendMsg("Pass all running missions.");
        }

        [CommandMethod("0 finish")]
        public void FinishRunningMission(CommandArg arg)
        {
            if (arg.Target == null)
            {
                arg.SendMsg("Player not found.");
                return;
            }

            if (arg.BasicArgs.Count < 1)
            {
                arg.SendMsg("Please specify the mission id.");
                return;
            }

            if (!int.TryParse(arg.BasicArgs[0], out var missionId))
            {
                arg.SendMsg("Invalid mission id.");
                return;
            }

            var mission = arg.Target!.Player!.MissionManager!;
            //mission.AcceptSubMission(missionId);  // if not accepted, the mission will not be finished
            mission.FinishSubMission(missionId);
            arg.SendMsg("Finish mission.");
        }

        [CommandMethod("0 running")]
        public void ListRunningMission(CommandArg arg)
        {
            if (arg.Target == null)
            {
                arg.SendMsg("Player not found.");
                return;
            }

            var mission = arg.Target!.Player!.MissionManager!;
            var runningMissions = mission.GetRunningSubMissionList();
            if (runningMissions.Count == 0)
            {
                arg.SendMsg("No running missions.");
                return;
            }

            arg.SendMsg("Running missions:");
            Dictionary<int, List<int>> map = [];

            foreach (var m in runningMissions)
            {
                if (!map.TryGetValue(m.MainMissionID, out List<int>? value))
                {
                    value = ([]);
                    map[m.MainMissionID] = value;
                }

                value.Add(m.ID);
            }

            var possibleStuckIds = new List<int>();
            var morePossibleStuckIds = new List<int>();

            foreach (var list in map)
            {
                arg.SendMsg($"Main mission {list.Key}:");
                var sb = new StringBuilder();
                foreach (var id in list.Value)
                {
                    sb.Append($"{id}, ");

                    if (id.ToString().StartsWith("10"))
                    {
                        possibleStuckIds.Add(id);

                        var info = mission.GetSubMissionInfo(id);
                        if (info != null && info.FinishType == Enums.MissionFinishTypeEnum.PropState)
                        {
                            morePossibleStuckIds.Add(id);
                        }
                    }
                }

                sb.Remove(sb.Length - 2, 2);

                arg.SendMsg(sb.ToString());
            }

            if (morePossibleStuckIds.Count > 0)
            {
                arg.SendMsg("You might be stuck in missions below:");

                var sb = new StringBuilder();
                foreach (var id in morePossibleStuckIds)
                {
                    sb.Append($"{id}, ");
                }

                sb.Remove(sb.Length - 2, 2);

                arg.SendMsg(sb.ToString());
            } else if (possibleStuckIds.Count > 0)
            {
                arg.SendMsg("You might be stuck in missions below:");

                var sb = new StringBuilder();
                foreach (var id in possibleStuckIds)
                {
                    sb.Append($"{id}, ");
                }

                sb.Remove(sb.Length - 2, 2);

                arg.SendMsg(sb.ToString());
            }
        }
    }
}
