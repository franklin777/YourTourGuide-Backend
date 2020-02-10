using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTGuideApi.Models;

namespace YTGuideApi.DbModels
{
    public class ObjectContext
    {
        public IConfiguration Configuration { get; }
        public IMongoDatabase _database = null;

        public ObjectContext(IOptions<Settings> settings)
        {
            Configuration = settings.Value.iConfigurationRoot;
            settings.Value.ConnectionString = Configuration.GetSection("MongoConection:ConnectionString").Value;
            settings.Value.Database = Configuration.GetSection("MongoConection:Database").Value;

            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoCollection<TourPackage> TourPackage
        {
            get
            {
                return _database.GetCollection<TourPackage>("TourPackage");
            }
        }
    }
}
