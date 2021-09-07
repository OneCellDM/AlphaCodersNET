using System.Threading.Tasks;
using WallsAlphaCodersLib.Group;
using WallsAlphaCodersLib.ResponseModels;
using WallsAlphaCodersLib.Tag;

namespace WallsAlphaCodersLib
{
    public class TagMethods
    {
        private WallpaperApi _Api;
        public TagMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetTag(TagRequestParams @params) =>
            await _Api.Request<WallpaperResponse, TagRequestParams>("Tag", @params);
        
        public async Task<int> GetTagCount(TagCountRequestParams @params) =>
            await _Api.GetCountRequest("Tag_count", @params);
    }
}