using System.Collections.Generic;
using AlphaCodersLib.WallPaperApi.ResponseModels.Data;

namespace AlphaCodersLib.WallPaperApi.ResponseModels
{
    public class WallpaperResponse 
    {
        public List<Wallpaper>? Wallpapers { get; set; }

        public string? Total_Match { get; set; }

        public bool? Check_Last { get; set; }
    }
}