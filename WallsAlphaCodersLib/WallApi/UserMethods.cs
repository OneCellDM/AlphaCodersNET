using System.Threading.Tasks;
using AlphaCodersLib.WallPaperApi.ResponseModels;
using AlphaCodersLib.WallPaperApi.User;
using AlphaCodersLib.WallPaperApi.Group;

namespace AlphaCodersLib.WallPaperApi
{
    public class UserMethods
    {
        private WallpaperApi _Api;
        public UserMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetUser(UserRequestParams @params) =>
            await _Api.Request<WallpaperResponse, UserRequestParams>("user", @params);
        
        
        public async Task<int> GetUserCount(UserCountRequestParams @params) =>
            await _Api.GetCountRequest("user_count", @params);
    }
}