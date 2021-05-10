using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace SAM_Console_Test
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                // tell the builder to look for the appSettings.json file
                .AddJsonFile("appSettings.json",  false, true)
                .AddUserSecrets<Program>()
                .Build();

            var serviceProvider = new ServiceCollection()
                //Map the implementations of your classes here ready for DI
                .Configure<ApiClientOptions>(settings =>
                {
                    settings.BaseUrl = Configuration.GetSection(nameof(ApiClientOptions))["baseUrl"];
                    settings.ApiKey = Configuration.GetSection(nameof(ApiClientOptions))["apiKey"];
                })
                .AddOptions()
                .AddSingleton<IApiClient, ApiClient>()
                .BuildServiceProvider();

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
}
