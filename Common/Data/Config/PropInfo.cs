﻿using EggLink.DanhengServer.Enums.Scene;
using EggLink.DanhengServer.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace EggLink.DanhengServer.Data.Config
{
    public class PropInfo : PositionInfo
    {
        public int MappingInfoID { get; set; }
        public int AnchorGroupID { get; set; }
        public int AnchorID { get; set; }
        public int PropID { get; set; }
        public int EventID { get; set; }
        public int CocoonID { get; set; }
        public int FarmElementID { get; set; }
        public bool IsClientOnly { get; set; }

        public PropValueSource? ValueSource { get; set; }
        public string? InitLevelGraph { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PropStateEnum State { get; set; } = PropStateEnum.Closed;

        [JsonIgnore()]
        public List<int> UnlockDoorID { get; set; } = [];

        public void Load()
        {
            if (ValueSource != null)
            {
                foreach (var v in ValueSource.Values)
                {
                    try
                    {
                        if (v["Value"] != null && v["Key"] != null)
                        {
                            if (v["Key"]?.ToString().Contains("Door") == true || v["Key"]?.ToString().Contains("Bridge") == true)
                            {
                                try
                                {
                                    UnlockDoorID.Add(int.Parse(v["Value"]!.ToString().Split(",")[1]));
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }
    }

    public class PropValueSource
    {
        public List<JObject> Values { get; set; } = [];
    }
}
