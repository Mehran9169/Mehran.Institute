using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class PaymentRepository
    {
        InstituteContext db = new InstituteContext();
        public int Add(Payment pay)
        {
            db.Payments.Add(pay);
            db.SaveChanges();
            return pay.PayementID;
        }

        public Payment GetById(int id)
        {
            Payment result = db.Payments.FirstOrDefault(x => x.PayementID == id);
            return result;
        }

        public string Update(Payment pay)
        {
            var oldPay = db.Payments.FirstOrDefault(x => x.PayementID == pay.PayementID);
            if (pay.RegisterationID == -1 || pay.Amount == 0 || pay?.PaymentDate is null )
            {
                return "فیلدهای اجباری نمی تواند خالی باشد";
            }
            else
            {
                oldPay.PaymentDate = pay.PaymentDate;
                oldPay.RegisterationID = pay.RegisterationID;
                oldPay.Amount = pay.Amount;
                oldPay.EmployeeID = pay.EmployeeID;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
            }
        }
        public void Delete(int payID)
        {
            db.Payments.Remove(db.Payments.FirstOrDefault(x => x.PayementID == payID));
            db.SaveChanges();
        }
        public List<Payment> GetAll()
        {
            var result = db.Payments.AsNoTracking().ToList();
            return result;
        }
    }
}
