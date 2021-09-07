using System.Threading.Tasks;
using WallsAlphaCodersLib.Group;
using WallsAlphaCodersLib.SubCategory;
using WallsAlphaCodersLib.ResponseModels;

namespace WallsAlphaCodersLib
{
    public class SubCategoryMethods
    {
        private WallpaperApi _Api;
        public SubCategoryMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetCategory(SubCategoryRequestParams @params) =>
            await _Api.Request<WallpaperResponse, SubCategoryRequestParams>("sub_category", @params);
        
        public async Task<SubCategoryResponse> GetCategoryList() => 
            await _Api.Request<SubCategoryResponse>("sub_category_list");
        
        public async Task<int> GetSubCategoryCount(SubCategoryCountRequestParams @params) =>
            await _Api.GetCountRequest("sub_category_count", @params);
    }
}