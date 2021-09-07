using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using WallsAlphaCodersLib.JsonConverters;
using WallsAlphaCodersLib.ResponseModels;
using WallsAlphaCodersLib;
using WallsAlphaCodersLib.Interfaces;

namespace WallsAlphaCodersLib
{
    public class WallpaperApi
    {
        private HttpClient _httpClient = new HttpClient();
        private const string apiUrl = "https://wall.alphacoders.com/api2.0/get.php";
        private string _Secret = string.Empty;

        private JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            Converters = {new StringToIntConverter()}
        };

        public SortMethods Sort { get; set; }
        public CollectionMethods Collection { get; set; }
        public CategoryMethods Category { get; set; }
        public GroupMethods Group { get; set; }
        public SubCategoryMethods SubCategory { get; set; }
        public FeaturedMethods Featured { get; set; }
        public PopularMethods Popular { get; set; }
        public TagMethods Tag { get; set; }
        public UserMethods User { get; set; }

        public async Task<int> GetCountRequest(string @method, ICountRequestParams @params)
        {
            if (@params is null) throw new ApiException("Request params is null");
            string url = $"{apiUrl}?auth={_Secret}&method={method}" + GetParams(@params);
            var res = await _httpClient.GetStringAsync(url);
            JObject responseObj = JObject.Parse(res);
            var Success = responseObj["success"].Value<bool>();
            return Success
                ? responseObj["count"].Value<int>()
                : throw new ApiException(responseObj["error"].Value<string?>());
        }

        public async Task<TResponse> Request<TResponse>(string @method)
        {
            var res = await _httpClient.GetStringAsync($"{apiUrl}?auth={_Secret}&method={@method}");
            JObject responseObj = JObject.Parse(res);
            Debug.WriteLine(res);
            var Success = responseObj["success"].Value<bool>();
            return Success
                ? JsonConvert.DeserializeObject<TResponse>(res, settings)
                : throw new ApiException(responseObj["error"].Value<string?>());
        }

        public async Task<TResponse?> Request<TResponse, TRequestParams>(string @method, TRequestParams @params)
        {
            if (@params is null) throw new ApiException("Request params is null");
            string url = $"{apiUrl}?auth={_Secret}&method={method}" + GetParams(@params);
            var res = await _httpClient.GetStringAsync(url);
            JObject responseObj = JObject.Parse(res);
            var Success = responseObj["success"].Value<bool>();
            Debug.WriteLine(res);
            return Success
                ? JsonConvert.DeserializeObject<TResponse>(res, settings)
                : throw new ApiException(responseObj["error"].Value<string?>());
        }

        private string GetParams<TRequestParams>(TRequestParams @params)
        {
            string res = string.Empty;
            var typeooft = @params.GetType();
            var type = typeooft.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var typeEnum = type.Select(it => new {it.Name, Value = typeooft.GetProperty(it.Name)?.GetValue(@params)})
                .Where(it => it.Value != null);
            foreach (var i in typeEnum) res += $"&{i.Name.ToLower()}={i.Value}";
            return res;
        }

        public async Task<WallpaperResponse> GetRandomWallpapers(RandomRequestParams @params) =>
            await Request<WallpaperResponse, RandomRequestParams>("random", @params);

        public async Task<WallpaperResponse> SearchWallpapers(SearchRequestParams @paramss) =>
            await Request<WallpaperResponse, SearchRequestParams>("search", @paramss);

        public async Task<WallpaperResponse> WallpaperInfo(int id) =>
            await Request<WallpaperResponse>($"search?id={id}");

        public async Task<QueryCountResponse> GetQueryCount() => await Request<QueryCountResponse>("query_count");

        public WallpaperApi(string secret)
        {
            _Secret = secret;
            Category = new(this);
            Collection = new(this);
            Sort = new(this);
            Group = new(this);
            SubCategory = new(this);
            Featured = new(this);
            Popular = new(this);
            Tag = new(this);
            User = new(this);
        }
    }
}