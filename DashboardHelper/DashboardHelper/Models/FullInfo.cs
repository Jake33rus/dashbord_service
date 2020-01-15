using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace DashboardHelper.Models
{
    public class FullInfo
    {
        [BsonId]
        public string Id { get; set; }
        //TODO: описать поля модели данных
    }
}
