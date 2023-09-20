using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class EducationDegreeRepository
    {
        private InstituteContext db = new InstituteContext();
        public EducationDegree GetById(int id)
        {
            EducationDegree result = db.EducationDegrees.FirstOrDefault(x => x.EducationDegreeID == id);
            return result;
        }

        public List<EducationDegree> GetAll()
        {
            return db.EducationDegrees.AsNoTracking().ToList();
        }
    }
}
