using System.Threading.Tasks;
using AlphaCodersLib.WallPaperApi.Featured;
using AlphaCodersLib.WallPaperApi.Group;
using AlphaCodersLib.WallPaperApi.ResponseModels;

namespace AlphaCodersLib.WallPaperApi
{
    public class FeaturedMethods
    {
        private WallpaperApi _Api;
        public FeaturedMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetFeatured(FeaturedRequestParams @params) =>
            await _Api.Request<WallpaperResponse, FeaturedRequestParams>("featured", @params);
        
        
        public async Task<int> GetFeaturedCount(GroupCountRequestParams @params) =>
            await _Api.GetCountRequest("featured_count", @params);
    }
}