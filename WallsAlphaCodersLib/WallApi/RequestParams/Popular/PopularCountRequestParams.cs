using AlphaCodersLib.WallPaperApi.Interfaces;

namespace AlphaCodersLib.WallPaperApi.Popular
{
    public class PopularCountRequestParams:ICountRequestParams
    {
        public int Id { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Operator { get; set; }
    }
}