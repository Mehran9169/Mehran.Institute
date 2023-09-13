using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return db.Cities.ToList();
        }
    }
}
