using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class TeacherRepository
    {
        private InstituteContext db = new InstituteContext();
        public int Add(Teacher tch)
        {
            db.Teachers.Add(tch);
            db.SaveChanges();
            return tch.TeacherID;
        }

        public Teacher GetById(int id)
        {
            Teacher result = db.Teachers.FirstOrDefault(x => x.TeacherID == id);
            return result;
        }

        public string Update(Teacher tch)
        {
            var oldTch = db.Teachers.FirstOrDefault(x => x.TeacherID == tch.TeacherID);
            if (tch.TeacherName == "" || tch.TeacherName is null || tch.Picture is null)
            {
                return "فیلدهای اجباری نمی تواند خالی باشد";
            }
            else
            {
                oldTch.TeacherName = tch.TeacherName;
                oldTch.AboutTeacher = tch.AboutTeacher;
                oldTch.Mobile = tch.Mobile;
                oldTch.ResumeDescription = tch.ResumeDescription;
                oldTch.ResumeFile = tch.ResumeFile;
                oldTch.Picture = tch.Picture;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
            }
        }
        public void Delete(int tchID)
        {
            db.Teachers.Remove(db.Teachers.FirstOrDefault(x => x.TeacherID == tchID));
            db.SaveChanges();
        }
        public IEnumerable<Teacher> GetAll()
        {
            var result = db.Teachers.ToList();
            return result;

        }
    }
}
