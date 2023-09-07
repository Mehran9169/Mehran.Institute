namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_Courses
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TermID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string TermName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseStatusID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CourseStatusName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeacherID { get; set; }

        [Key]
        [Column(Order = 5)]
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

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string CourseName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tuition { get; set; }

        [StringLength(100)]
        public string Preq { get; set; }

        public int? Hours { get; set; }

        [StringLength(100)]
        public string RuningTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CourseContent { get; set; }
    }
}
