using System.Collections.Generic;
using System.Threading.Tasks;
using ecomm1.Models;
using MongoDB.Driver;


namespace ecomm1.Repo
{
    public class MongoRepo : IMongoRepo
    {
        IMongoClient _client;
        IMongoDatabase _db;
        

        public MongoRepo()
        {
            _client = new MongoClient("mongo://localhost:27017");
            _db = _client.GetDatabase("VareDB");
        }
        

        public string AddVare(vare vareData)
        {
            var collection = _db.GetCollection<vare>("VareCollection");
            collection.InsertOne(vareData);
            return "data added";
        }

        public async Task<IEnumerable<vare>> GetAllVare()
        {
            var collection = _db.GetCollection<vare>("VareCollection");
            var res = await collection.Find(_client => true).ToListAsync();
            return res;
        }

        public vare GetSpecVare(int vareId)
        {
            throw new System.NotImplementedException();
        }

        public string UpdateVare(vare vareData)
        {
            throw new System.NotImplementedException();
        }
    }
}