using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace SAM_Console_Test
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static async Task Main(string[] args)
        {
            var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) ||
                                devEnvironmentVariable.ToLower() == "development";
            //Determines the working environment as IHostingEnvironment is unavailable in a console app

            var builder = new ConfigurationBuilder();
            
            // tell the builder to look for the appsettings.json file
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //only add secrets in development
            if (isDevelopment)
            {
                builder.AddUserSecrets<Program>();
            }
            
            Configuration = builder.Build();

            var services = new ServiceCollection();

            //Map the implementations of your classes here ready for DI
            services
                .Configure<ApiClientOptions>(settings =>
                {
                    settings.BaseUrl = Configuration.GetSection(nameof(ApiClientOptions))["baseUrl"];
                    settings.ApiKey = Configuration.GetSection(nameof(ApiClientOptions))["apiKey"];
                })
                .AddOptions()
                .AddSingleton<IApiClient, ApiClient>()
                .BuildServiceProvider();

            var serviceProvider = services.BuildServiceProvider();
            var apiClient = serviceProvider.GetService<IApiClient>();

            if (apiClient == null)
            {
                Console.WriteLine("No IApiClient service found");
                return;
            }

            var response = await apiClient.GetEntityManagementDataUsingQueryAsync("(dbaName:'John Snow')");
            Console.WriteLine($"Found {response?.TotalRecords ?? 0} registrations");
            response?.EntityData.ForEach(entity => Console.WriteLine($"Entity: {entity.EntityRegistration.LegalBusinessName}"));

            Console.WriteLine();

            response = await apiClient.GetEntityManagementDataByDunsAsync("195259502");
            Console.WriteLine($"Found {response?.TotalRecords ?? 0} registration(s) by DUNS lookup");
            response?.EntityData.ForEach(entity => Console.WriteLine($"Entity: {entity.EntityRegistration.LegalBusinessName}"));
        }
    }

    public class ApiClientOptions
    {
        public string ApiKey { get; set; }

        public string BaseUrl { get; set; }
    }

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

        public ApiClient(IOptions<ApiClientOptions> secrets)
        {
            AppSettings = secrets.Value;
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
