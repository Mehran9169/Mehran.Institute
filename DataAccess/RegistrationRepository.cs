using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RegistrationRepository
    {
        private InstituteContext db = new InstituteContext();

        public int Add(Registration reg)
        {
            db.Registrations.Add(reg);
            db.SaveChanges();
            return reg.RegistrationID;
        }

        public Registration GetById(int id)
        {
            Registration result = db.Registrations.FirstOrDefault(x => x.RegistrationID == id);
            return result;
        }

        public string Update(Registration reg)
        {
            var oldReg = db.Registrations.FirstOrDefault(x => x.RegistrationID == reg.RegistrationID);
                oldReg.RegistrationDate= reg.RegistrationDate;
                oldReg.CourseID= reg.CourseID;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
        }
        public void Delete(int regID)
        {
            db.Registrations.Remove(db.Registrations.FirstOrDefault(x => x.RegistrationID == regID));
            db.SaveChanges();
        }
        public List<Registration> GetAll()
        {
            var result = db.Registrations.AsNoTracking().ToList();
            return result;
        }
        public List<RegistrationListItem> GetRegListDropDown()
        {

            var q = from c in db.Registrations.AsNoTracking()
                    select new RegistrationListItem
                    {
                        RegistrationID = c.RegistrationID,
                        FullInfo = c.RegistrationID + " - " + c.Student.FirstName + " " + c.Student.LastName  + " - "
                        + c.Course.CourseName
                    };
            return q.ToList();
        }

        public int Summary(int id)
        {
            var regItem = db.Registrations.AsNoTracking()
                            .FirstOrDefault(x => x.RegistrationID == id).Payments;
            var sum = regItem.Sum(x => x.Amount);
            return sum;
        }

    }
}
