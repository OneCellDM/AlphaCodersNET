using System.Threading.Tasks;
using WallsAlphaCodersLib.Group;
using WallsAlphaCodersLib.ResponseModels;
using WallsAlphaCodersLib.User;

namespace WallsAlphaCodersLib
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