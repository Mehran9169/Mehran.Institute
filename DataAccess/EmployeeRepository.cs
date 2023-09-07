using DomainModel.Models;
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

    }
}
