using Microsoft.Extensions.Configuration;


namespace ADO.NET_Console_CRUD_application.Context
{
    public class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configuration = new ConfigurationManager();
               // configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../../"));
                configuration.SetBasePath(Directory.GetCurrentDirectory());
                configuration.AddJsonFile("appsettings.json");

                return configuration.GetConnectionString("Sql");
            }
        }
    }
}
