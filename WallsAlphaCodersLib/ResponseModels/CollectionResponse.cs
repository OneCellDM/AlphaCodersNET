using System.Collections.Generic;
using Newtonsoft.Json;
using WallsAlphaCodersLib.ResponseModels.Data;

namespace WallsAlphaCodersLib.ResponseModels
{
    public class CollectionResponse
    {
        [JsonProperty("collections")]
        public  List<Data.Collection> Items { get; set; }
    }
}