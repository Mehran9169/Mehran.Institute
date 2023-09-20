using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseStatusRepository
    {
        private InstituteContext db = new InstituteContext();
        public CourseStatus GetById(int id)
        {
            CourseStatus result = db.CourseStatus.FirstOrDefault(x => x.CourseStatusID == id);
            return result;
        }

        public List<CourseStatus> GetAll()
        {
            return db.CourseStatus.AsNoTracking().ToList();
        }


    }
}
