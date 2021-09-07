using System.Threading.Tasks;
using AlphaCodersLib.WallPaperApi.Group;
using AlphaCodersLib.WallPaperApi.ResponseModels;
using AlphaCodersLib.WallPaperApi.Category;

namespace AlphaCodersLib.WallPaperApi
{
    public class GroupMethods
    {
        private WallpaperApi _Api;
        public GroupMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetGroupCategory(GroupRequestParams @params) =>
            await _Api.Request<WallpaperResponse, GroupRequestParams>("group", @params);
        
        public async Task<GroupResponse> GetGroupList() => 
            await _Api.Request<GroupResponse>("group_list");
        
        public async Task<int> GetGroupCount(GroupCountRequestParams @params) =>
            await _Api.GetCountRequest("group_count", @params);
    }
}