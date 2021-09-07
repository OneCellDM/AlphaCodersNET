using System.Collections.Generic;
using WallsAlphaCodersLib.ResponseModels.Data;

namespace WallsAlphaCodersLib.ResponseModels
{
    public class WallpaperResponse 
    {
        public List<Wallpaper>? Wallpapers { get; set; }

        public string? Total_Match { get; set; }

        public bool? Check_Last { get; set; }
    }
}