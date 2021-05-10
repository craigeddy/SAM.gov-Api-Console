using Microsoft.Extensions.Configuration;

namespace SAM_Console_Test
{
    public static class AppConfig
    {
        public static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json", true, true)
                .AddUserSecrets<Program>();

            return builder.Build();
        }

        public static T InitOptions<T>(string section)
            where T : new()
        {
            var config = GetConfiguration();
            var x = new T();
            config.Bind(section, x);
            return x;
        }
    }
}