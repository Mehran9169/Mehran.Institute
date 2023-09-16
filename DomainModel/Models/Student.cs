namespace DomainModel.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Registrations = new HashSet<Registration>();
        }

        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string NationalCode { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int CityID { get; set; }

        public int EducationDegreeID { get; set; }

        public virtual City City { get; set; }

        public virtual EducationDegree EducationDegree { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }

        public string CityName
        {
            get
            {
                if (!(this.City is null))
                {
                    return this.City.CityName;
                }
                else
                {
                    return null;
                }
            }
        }
        public string EducationDegreeName
        {
            get
            {
                if (!(this.EducationDegree is null))
                {
                    return this.EducationDegree.EducationDegreeName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
