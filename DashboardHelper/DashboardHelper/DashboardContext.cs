using DashboardHelper.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardHelper
{
    public class DashboardContext
    {
        private readonly IMongoDatabase _database = null;

        public DashboardContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<FullInfo> Informations => _database.GetCollection<FullInfo>("FullInfo");
    }
}
