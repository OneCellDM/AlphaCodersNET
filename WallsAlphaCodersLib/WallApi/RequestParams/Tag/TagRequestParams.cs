using AlphaCodersLib.WallPaperApi.Interfaces;

namespace AlphaCodersLib.WallPaperApi.Tag
{
    public class TagRequestParams:IRequestParams
    {
        public int Id { get; set; }
        public int? Info_Level { get; set; }
        public  string? Sort { get; set; }
        public  int? Page { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Operator { get; set; }
        public bool Check_Last { get; set; }
    }
}