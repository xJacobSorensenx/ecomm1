using System.Collections.Generic;
using System.Threading.Tasks;
using ecomm1.Models;
using MongoDB.Bson;

namespace ecomm1.Repo
{
    public interface IMongoRepo
    {
         Task<IEnumerable<vare>> GetAllVare();
         Task<vare> GetSpecVare(string vareId);
         string AddVare(vare vareData);
         Task<string> UpdateVare(string vareid, vare vareData);
         string SletVare(string vareId);
    }
}