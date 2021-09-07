using WallsAlphaCodersLib.Interfaces;

namespace WallsAlphaCodersLib.Featured
{
    public class FeaturedCountRequestParams:ICountRequestParams
    {
        public int Id { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Operator { get; set; }
    }
}