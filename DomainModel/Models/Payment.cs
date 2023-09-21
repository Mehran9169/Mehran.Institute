namespace DomainModel.Models
{
    using FrameWork;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        public int PayementID { get; set; }

        public int RegisterationID { get; set; }

        public int Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public int EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Registration Registration { get; set; }

        public string RegistrInfo
        {
            get
            {
                var info = Registration.RegistrationID + " - " + Registration.RegisterInf;
                return info;
            }
        }

        public string EmployeeFullName
        {
            get
            {
                return this.Employee.FullName;
            }
        }
        public string PaymentDateShamsi
        {
            get { return DateHelper.GetPersianDate(this.PaymentDate); }
        }
    }
}
