using System.IO;
using Microsoft.Extensions.Configuration;

namespace TestFramework.Dto
{
    public class DriverConfiguration
    {
        public string DriverPath { get; set; }
        public string Url { get; set; }

        public int DefaultTimeout { get; set; }

        public DriverConfiguration Bind()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            config.GetSection("DriverConfiguration").Bind(this);
            return this;
        }
    }
}