using WallsAlphaCodersLib.Interfaces;

namespace WallsAlphaCodersLib.SubCategory
{
    public class SubCategoryCountRequestParams:ICountRequestParams
    {
        public int Id { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Operator { get; set; }
    }
}