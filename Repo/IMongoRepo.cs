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
         string UpdateVare(vare vareData);
    }
}