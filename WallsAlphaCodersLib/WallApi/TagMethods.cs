using System.Threading.Tasks;
using AlphaCodersLib.WallPaperApi.ResponseModels;
using AlphaCodersLib.WallPaperApi.Tag;
using AlphaCodersLib.WallPaperApi.Group;

namespace AlphaCodersLib.WallPaperApi
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