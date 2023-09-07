using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DomainModel.Models
{
    public partial class InstituteContext : DbContext
    {
        public InstituteContext()
            : base("name=InstituteContext")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseStatus> CourseStatus { get; set; }
        public virtual DbSet<EducationDegree> EducationDegrees { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<VW_Courses> VW_Courses { get; set; }
        public virtual DbSet<VW_Registeration> VW_Registeration { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EducationDegree>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.EducationDegree)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registration>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Registration)
                .HasForeignKey(e => e.RegisterationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Term>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Term)
                .WillCascadeOnDelete(false);
        }
    }
}
