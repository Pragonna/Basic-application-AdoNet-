using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    public static class Configuration
    {
        public static string GetConnectionString
        {
            get
            {
                ConfigurationManager configuration = new ConfigurationManager();

                // configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../"));
                configuration.SetBasePath(Directory.GetCurrentDirectory());
                configuration.AddJsonFile("appsettings.json");

                return configuration.GetConnectionString("Sql");
            }
        }
    }
}
