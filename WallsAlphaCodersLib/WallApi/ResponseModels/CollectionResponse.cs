using System.Collections.Generic;
using Newtonsoft.Json;
using AlphaCodersLib.WallPaperApi.ResponseModels.Data;

namespace AlphaCodersLib.WallPaperApi.ResponseModels
{
    public class CollectionResponse
    {
        [JsonProperty("collections")]
        public  List<Data.Collection> Items { get; set; }
    }
}