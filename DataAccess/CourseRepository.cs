using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseRepository
    {
        private InstituteContext db = new InstituteContext();

        public int Add(Course cor)
        {
            db.Courses.Add(cor);
            db.SaveChanges();
            return cor.CourseID;
        }

        public Course GetById(int id)
        {
            Course result = db.Courses.FirstOrDefault(x => x.CourseID== id);
            return result;
        }

        public string Update(Course cor)
        {
            var oldCor = db.Courses.FirstOrDefault(x => x.CourseID == cor.CourseID);
            if (cor.CourseName is null || cor?.Tuition is null || cor?.TeacherID == null || cor?.StartDate == null || cor?.TermID == null)
            {
                return "فیلدهای اجباری نمی تواند خالی باشد";
            }
            else
            {
                oldCor.CourseName = cor.CourseName;
                oldCor.Tuition = cor.Tuition;
                oldCor.TeacherID = cor.TeacherID;
                oldCor.Preq = cor.Preq;
                oldCor.Hours = cor.Hours;
                oldCor.RuningTime = cor.RuningTime;
                oldCor.StartDate = cor.StartDate;
                oldCor.EndDate = cor.EndDate;
                oldCor.CourseContent = cor.CourseContent;
                oldCor.TermID = cor.TermID;
                oldCor.CourseStatusID = cor.CourseStatusID;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
            }
        }
        public void Delete(int corID)
        {
            db.Courses.Remove(db.Courses.FirstOrDefault(x => x.CourseID == corID));
            db.SaveChanges();
        }
        public List<Course> GetAll()
        {
            var result = db.Courses.ToList();
            return result;
        }
    }
}
