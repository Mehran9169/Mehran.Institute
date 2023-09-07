namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }

        public int TeacherID { get; set; }

        [Required]
        [StringLength(100)]
        public string TeacherName { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(400)]
        public string ResumeFile { get; set; }

        public string ResumeDescription { get; set; }

        [StringLength(200)]
        public string AboutTeacher { get; set; }

        [StringLength(400)]
        public string Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
