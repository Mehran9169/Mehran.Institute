namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_Registeration
    {
        public int? RegistrationID { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public int? CourseID { get; set; }

        public int? StudentID { get; set; }

        public int? EmployeeID { get; set; }

        public int? Tuition { get; set; }

        public int? TotalPayment { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [StringLength(200)]
        public string CourseName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string StudentFirstName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string StudentLastName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string NationalCode { get; set; }

        [StringLength(100)]
        public string EmployeeFirstName { get; set; }

        [StringLength(100)]
        public string EmployeeLastName { get; set; }
    }
}
