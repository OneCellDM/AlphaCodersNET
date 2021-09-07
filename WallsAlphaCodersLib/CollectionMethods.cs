using System.Threading.Tasks;
using WallsAlphaCodersLib.Collection;
using WallsAlphaCodersLib.ResponseModels;

namespace WallsAlphaCodersLib
{
    public class CollectionMethods
    {
        private WallpaperApi _Api;
        
        public CollectionMethods(WallpaperApi api) => _Api = api;
        
        public async Task<WallpaperResponse?> GetCollection(CollectionRequestParams @params) =>
            await _Api.Request<WallpaperResponse, CollectionRequestParams>("collection", @params);
        
        
        public async Task<CollectionResponse?> GetCollectionList() =>
            await _Api.Request<CollectionResponse>("collection_list");
        
        public async Task<int> GetCollectionCount(CollectionCountRequestParams @params) =>
            await _Api.GetCountRequest("collection_count", @params);
    }
}