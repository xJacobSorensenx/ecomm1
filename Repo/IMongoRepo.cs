using System.Collections.Generic;
using ecomm1.Models;

namespace ecomm1.Repo
{
    public interface IMongoRepo
    {
         IEnumerable<vare> GetAllVare();
         vare GetSpecVare(int vareId);
         string AddVare(vare vareData);
         string UpdateVare(vare vareData);
    }
}