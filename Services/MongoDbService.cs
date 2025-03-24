using J30_API_SEGURO.Models;
using MongoDB.Driver;

namespace J30_API_SEGURO.Services
{
    public class MongoDbService
    {
        private readonly IMongoCollection<Auto> _AutosCollection;
        private readonly IMongoCollection<Ventas> _VentasCollection;

        public MongoDbService(IConfiguration config)
        {
            var client = new MongoClient(config["MongoSettings:ConnectionString"]);
            var database = client.GetDatabase(config["MongoSettings:DatabaseName"]);
            _AutosCollection = database.GetCollection<Auto>(config["MongoSettings:CollectionName"]);
            _VentasCollection = database.GetCollection<Ventas>(config["MongoSettings:CollectionName2"]);

         
            
        }
    }
}
