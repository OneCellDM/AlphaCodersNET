using System.Collections.Generic;
using Newtonsoft.Json;


namespace WallsAlphaCodersLib.ResponseModels
{
    public class CategoryResponse
    {
        [JsonProperty("categories")]

        public List<Data.Category> Items { get; set; }
    }
}