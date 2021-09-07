using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace WallsAlphaCodersLib.ResponseModels
{
    public class GroupResponse
    {
        [JsonProperty("groups")]
        public  List<Data.Group> Items { get; set; }
    }
}