using Microsoft.Extensions.Configuration;
namespace YTGuideApi.DbModels
{
    public class Settings
    {
        public string ConnectionString;
        public string Database;
        public  IConfiguration iConfigurationRoot;
    }
}
