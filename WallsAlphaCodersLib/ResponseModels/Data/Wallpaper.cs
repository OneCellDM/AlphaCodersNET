namespace WallsAlphaCodersLib.ResponseModels.Data
{
    public class Wallpaper
    {
        public int? Id { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? File_Type { get; set; }
        public long? File_Size { get; set; }
        public string? Url_Image { get; set; }
        public string? Url_Thumb { get; set; }
        public string? Url_Page { get; set; }
        public string? Category { get; set; }
        public int? Category_Id { get; set; }
        public string? Sub_Category { get; set; }
        public int? Sub_Category_Id { get; set; }
        public string? User_Name { get; set; }
        public int? user_id { get; set; }
        public string? Collection { get; set; }
        public int? Collection_Id { get; set; }
        public string? Group { get; set; }
        public int? Group_id { get; set; }
    }
}