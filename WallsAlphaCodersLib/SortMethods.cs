using System.Threading.Tasks;
using WallsAlphaCodersLib;
using WallsAlphaCodersLib.ResponseModels;

namespace WallsAlphaCodersLib
{
    public class SortMethods
    {
        private WallpaperApi _Api;

        public SortMethods(WallpaperApi api) => _Api = api;


        public async Task<WallpaperResponse?> Newest(SortRequestParams @params) =>
            await _Api.Request<WallpaperResponse, SortRequestParams>("newest", @params);

        public async Task<WallpaperResponse?> HighestRated(SortRequestParams @params) =>
            await _Api.Request<WallpaperResponse, SortRequestParams>("highest_rated", @params);

        public async Task<WallpaperResponse?> ByViews(SortRequestParams @params) =>
            await _Api.Request<WallpaperResponse, SortRequestParams>("by_views", @params);

        public async Task<WallpaperResponse?> ByFavorites(SortRequestParams @params) =>
            await _Api.Request<WallpaperResponse, SortRequestParams>("by_favorites", @params);
    }
}