using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class EmployeeRepository
    {
        private InstituteContext db = new InstituteContext();
        public bool Login(string username, string password)
        {
            bool auth = db.Employees.Any(x => x.UserName == username && x.Password == password);
            return auth;
        }
        public bool Validate(string username, string password)
        {
            if (db.Employees.Any(x => x.UserName == username && x.Password == password))
            {
                return true;
            }
            return false;
        }
        public int Add(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return emp.EmployeeID;
        }

        public Employee GetById(int id)
        {
            Employee result = db.Employees.FirstOrDefault(x => x.EmployeeID == id);
            return result;
        }

        public string Update(Employee emp)
        {
            var oldEmp = db.Employees.FirstOrDefault(x => x.EmployeeID == emp.EmployeeID);
            if (emp.FirstName  == "" || emp.LastName == "" || emp.Mobile == "" || emp.UserName == "" || emp.Password == "")
            {
                return "فیلدهای اجباری نمی تواند خالی باشد";
            }
            else
            {
                oldEmp.FirstName = emp.FirstName;
                oldEmp.LastName = emp.LastName;
                oldEmp.Mobile = emp.Mobile;
                oldEmp.UserName = emp.UserName;
                oldEmp.Password = emp.Password;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
            }
        }
        public void Delete(int empID)
        {
            db.Employees.Remove(db.Employees.FirstOrDefault(x => x.EmployeeID == empID));
            db.SaveChanges();
        }
        public List<Employee> GetAll()
        {
            var result = db.Employees.ToList();
            return result;
        }
        public string GetCurrentUser(string username)
        {
            var user = db.Employees.FirstOrDefault(x => x.UserName == username).FullName;
            return user;
        }

    }
}
