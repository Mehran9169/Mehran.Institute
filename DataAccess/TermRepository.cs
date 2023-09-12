using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class TermRepository
    {
        private readonly InstituteContext db = new InstituteContext();
        public int Add(Term trm)
        {
            db.Terms.Add(trm);
            db.SaveChanges();
            return trm.TermID;
        }

        public Term GetById(int id)
        {
            Term result = db.Terms.FirstOrDefault(x => x.TermID == id);
            return result;
        }

        public string Update(Term trm)
        {
            var oldTerm = db.Terms.FirstOrDefault(x => x.TermID == trm.TermID);
            if (trm.TermName == null || trm.TermName == string.Empty)
            {
                return "فیلد ترم نمی تواند خالی باشد";
            }
            else
            {
                oldTerm.TermName = trm.TermName;
                db.SaveChanges();
                return "عملیات موفق آمیز بود";
            }
        }
        public void Delete(int TermID)
        {
            db.Terms.Remove(db.Terms.FirstOrDefault(x => x.TermID == TermID));
            db.SaveChanges();
        }
        public List<Term> GetAll()
        {
            var result = db.Terms.ToList();
            return result;

        }
    }
}
