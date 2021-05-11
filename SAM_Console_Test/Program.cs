using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using Insight.Database;
using Microsoft.Extensions.Configuration;

namespace SAM_Console_Test
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            var cfg = AppConfig.InitOptions<ApiClientOptions>("ApiClientOptions");

            var apiClient = new ApiClient(cfg);
            
            var connectionString = AppConfig.GetConfiguration().GetConnectionString("fitdb");
            var database = new SqlConnectionStringBuilder(connectionString);

            var x = new Stopwatch();
            x.Start();
            
            var partners = database.Connection().QuerySql<PartnerRecord>("SELECT * FROM Common.Partners");
            
            x.Stop();
            Console.WriteLine($"Loaded {partners.Count} partners in {x.Elapsed}");
            Console.WriteLine();

            var response = await apiClient.GetEntityManagementDataUsingQueryAsync("(dbaName:'John Snow')");
            Console.WriteLine($"Found {response?.TotalRecords ?? 0} registrations");
            response?.EntityData.ForEach(entity => Console.WriteLine($"Entity: {entity.EntityRegistration.LegalBusinessName}"));

            Console.WriteLine();

            response = await apiClient.GetEntityManagementDataByDunsAsync("195259502");
            Console.WriteLine($"Found {response?.TotalRecords ?? 0} registration(s) by DUNS lookup");
            response?.EntityData.ForEach(entity => Console.WriteLine($"Entity: {entity.EntityRegistration.LegalBusinessName}"));
        }
    }

    public class PartnerRecord
    {
        public int RecordID { get; set; }

        public Guid PartnerID { get; set; }

        public string FACTSInfoName { get; set; }

        public string DUNS { get; set; }
    }
}