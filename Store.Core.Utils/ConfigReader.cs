using Microsoft.Extensions.Configuration;
using System.IO;

namespace Store.Core.Utils
{
    public class ConfigReader
    {
        public static string GetValue(string key)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            IConfiguration Configuration = root;
            string strValue = Configuration.GetValue<string>(key);
            return strValue;
        }
    }
}
