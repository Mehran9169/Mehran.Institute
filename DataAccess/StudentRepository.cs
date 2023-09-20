using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentRepository
    {
        private InstituteContext db = new InstituteContext();

        public int Add(Student stu)
        {
            db.Students.Add(stu);
            db.SaveChanges();
            return stu.StudentID;
        }

        public Student GetById(int id)
        {
            Student result = db.Students.FirstOrDefault(x => x.StudentID == id);
            return result;
        }

        public string Update(Student stu)
        {
            var oldStu = db.Students.FirstOrDefault(x => x.StudentID== stu.StudentID);
            if (stu.FirstName == string.Empty || stu.LastName == string.Empty || stu.NationalCode == string.Empty || stu.CityID == -1 || stu.EducationDegreeID == -1)
            {
                return "فیلدهای اجباری نمی تواند خالی باشد";
            }
            else
            {
                oldStu.FirstName = stu.FirstName;
                oldStu.LastName = stu.LastName;
                oldStu.NationalCode = stu.NationalCode;
                oldStu.CityID = stu.CityID;
                oldStu.Address = stu.Address;
                oldStu.Mobile= stu.Mobile;
                oldStu.EducationDegreeID= stu.EducationDegreeID;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
            }
        }
        public void Delete(int stuID)
        {
            db.Students.Remove(db.Students.FirstOrDefault(x => x.StudentID == stuID));
            db.SaveChanges();
        }
        public List<Student> GetAll()
        {
            var result = db.Students.AsNoTracking().ToList();
            return result;
        }
        public List<Student> Search(Student sm)
        {
            var q = from item in db.Students select item;
            if (!string.IsNullOrEmpty(sm.FirstName))
            {
                q = q.Where(x => x.FirstName.StartsWith(sm.FirstName));
            }
            if (sm.LastName != null)
            {
                q = q.Where(x => x.LastName.StartsWith(sm.LastName));
            }
            if (sm.NationalCode != null)
            {
                q = q.Where(x => x.NationalCode.StartsWith(sm.NationalCode));
            }
            if (sm.Mobile != null)
            {
                q = q.Where(x => x.Mobile.StartsWith(sm.Mobile));
            }
            return q.ToList();
        }
    }
}
