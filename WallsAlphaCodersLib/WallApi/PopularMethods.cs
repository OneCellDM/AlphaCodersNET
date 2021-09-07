using System.Threading.Tasks;
using AlphaCodersLib.WallPaperApi.Group;
using AlphaCodersLib.WallPaperApi.Popular;
using AlphaCodersLib.WallPaperApi.ResponseModels;

namespace AlphaCodersLib.WallPaperApi
{
    public class PopularMethods
    {
        private WallpaperApi _Api;
        public PopularMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetPopularCategory(PopularRequestParams @params) =>
            await _Api.Request<WallpaperResponse, PopularRequestParams>("popular", @params);
        
       
        
        public async Task<int> GetPopularCount(GroupCountRequestParams @params) =>
            await _Api.GetCountRequest("popular_count", @params);
    }
}