namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Registrations = new HashSet<Registration>();
        }

        public int CourseID { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        public int Tuition { get; set; }

        public int TeacherID { get; set; }

        [StringLength(100)]
        public string Preq { get; set; }

        public int? Hours { get; set; }

        [StringLength(100)]
        public string RuningTime { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CourseContent { get; set; }

        public int TermID { get; set; }

        public int? CourseStatusID { get; set; }

        public virtual CourseStatus CourseStatu { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Term Term { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
