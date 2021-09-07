using System.Collections.Generic;
using Newtonsoft.Json;

namespace WallsAlphaCodersLib.ResponseModels
{
    public class SubCategoryResponse
    {
        [JsonProperty("sub-categories")]
        public  List<Data.SubCategory> Items { get; set; }
    }
}