using System;
using System.Threading.Tasks;

namespace SAM_Console_Test
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            var cfg = AppConfig.InitOptions<ApiClientOptions>("ApiClientOptions");

            var apiClient = new ApiClient(cfg);

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