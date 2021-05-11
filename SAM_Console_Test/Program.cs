using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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

            var partners = database.Connection()
                .QuerySql<PartnerRecord>("SELECT * FROM Common.Partners")
                .ToList();
            
            Console.WriteLine($"Loaded {partners.Count}");
            Console.WriteLine();

            var response = await apiClient.GetEntityManagementDataUsingQueryAsync("(dbaName:'John Snow')");
            Console.WriteLine($"Found {response?.TotalRecords ?? 0} registrations");
            response?.EntityData.ForEach(entity => Console.WriteLine($"Entity: {entity.EntityRegistration.LegalBusinessName}"));

            Console.WriteLine();

            partners.ForEach(partner =>
            {
                try
                {
                    response = apiClient.GetEntityManagementDataByDunsAsync(partner.DUNS).Result;
                    
                    if (response.EntityData.Any())
                    {
                        Console.WriteLine($"Partner DUNS {partner.DUNS} has UEID {response.EntityData.First().EntityRegistration.UeiSAM}");
                    }
                    else
                    {
                        Console.WriteLine($"Unable to find {partner.DUNS}");
                    }

                    Thread.Sleep(new TimeSpan(0,0,0,30));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception with {partner.DUNS}: {ex.Message}");
                }

            });
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