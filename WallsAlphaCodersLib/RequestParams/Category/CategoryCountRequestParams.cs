

using WallsAlphaCodersLib.Interfaces;

namespace WallsAlphaCodersLib.Category
{
    public class CategoryCountRequestParams:ICountRequestParams
    {
        public int Id { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Operator { get; set; }
    }
}