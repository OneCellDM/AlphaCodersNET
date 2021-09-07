using System.Threading.Tasks;
using WallsAlphaCodersLib.Featured;
using WallsAlphaCodersLib.Group;
using WallsAlphaCodersLib.ResponseModels;

namespace WallsAlphaCodersLib
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