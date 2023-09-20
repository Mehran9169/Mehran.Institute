using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class CityRepository
    {
        private InstituteContext db = new InstituteContext();
        public City GetById(int id)
        {
            City result = db.Cities.FirstOrDefault(x => x.CityID == id);
            return result;
        }

        public List<City> GetAll()
        {
            return db.Cities.AsNoTracking().ToList();
        }
    }
}
