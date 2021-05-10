using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SAM_Console_Test
{
    public interface IApiClient
    {
        Task<ApiResponse> GetEntityManagementDataUsingQueryAsync(string q);

        Task<ApiResponse> GetEntityManagementDataByDunsAsync(string duns);
    }

    public class ApiClient: IDisposable, IApiClient
    {
        private readonly openapiClient _client;
        private readonly HttpClient _httpClient;

        public ApiClientOptions AppSettings { get; set; }

        public ApiClient(ApiClientOptions secrets)
        {
            AppSettings = secrets;
            _httpClient = new HttpClient();

            _client = new openapiClient(_httpClient)
            {
                BaseUrl = AppSettings.BaseUrl
            };
        }

        public async Task<ApiResponse> GetEntityManagementDataUsingQueryAsync(string q)
        {
            return await _client.GetEntityManagementDataUsingQueryAsync(AppSettings.ApiKey, q);
        }

        public async Task<ApiResponse> GetEntityManagementDataByDunsAsync(string duns)
        {
            return await _client.GetEntityManagementDataByDunsAsync(AppSettings.ApiKey, duns);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}