using System.Collections.Generic;
using System.Threading.Tasks;
using ecomm1.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;


namespace ecomm1.Repo
{
    public class MongoRepo : IMongoRepo
    {
        IMongoClient _client;
        IMongoDatabase _db;
        string collectionNavn;
        

        public MongoRepo()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("VareDB");
            collectionNavn = "VareCollection2";
        }
        

        public string AddVare(vare vareData)
        {
            var collection = _db.GetCollection<vare>(collectionNavn);
            collection.InsertOne(vareData);
            return "data added";
        }

        public async Task<IEnumerable<vare>> GetAllVare()
        {
            var collection = _db.GetCollection<vare>(collectionNavn);
            var res = await collection.Find(_client => true).ToListAsync();
            return res;
        }

        public async Task<vare> GetSpecVare(string incId)
        {
            var collection = _db.GetCollection<vare>(collectionNavn);
            var res = await collection.Find(v => v.VareId == incId).FirstOrDefaultAsync();

            return res;
        }

        public async Task<string> UpdateVare(string vareid, vare vareData)
        {
            var collection = _db.GetCollection<vare>(collectionNavn);
            var filter = Builders<vare>.Filter.Eq(v => v.VareId, vareid);
            var res =await collection.ReplaceOneAsync(filter, vareData);
            return "Data opdateret";
        }

        public string SletVare(string vareid){
            var collection = _db.GetCollection<vare>(collectionNavn);
            collection.DeleteOne(v => v.VareId == vareid);
            return $"vare med id: {vareid} er blevet slettet";
        }
    }
}