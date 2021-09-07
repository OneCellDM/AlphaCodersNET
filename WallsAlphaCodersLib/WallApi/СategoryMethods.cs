using System.Threading.Tasks;
using AlphaCodersLib.WallPaperApi.Category;
using AlphaCodersLib.WallPaperApi.ResponseModels;
using AlphaCodersLib.WallPaperApi;

namespace AlphaCodersLib.WallPaperApi
{
    public class CategoryMethods
    {
        private WallpaperApi _Api;
        public CategoryMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetCategory(CategoryRequestParams @params) =>
            await _Api.Request<WallpaperResponse, CategoryRequestParams>("category", @params);
        
        public async Task<CategoryResponse> GetCategoryList() => 
            await _Api.Request<CategoryResponse>("category_list");

        public async Task<int> GetCategoryCount(CategoryCountRequestParams @params) =>
            await _Api.GetCountRequest("category_count", @params);




    }
}