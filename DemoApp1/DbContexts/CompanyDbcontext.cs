using DemoApp1.InheritanceExamaple.Entities;
using DemoApp1.ModelConfigrations;
using DemoApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.DbContexts
{
    internal class CompanyDbcontext : DbContext
    {
        public CompanyDbcontext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server= .; Database = CompanyDb;Trusted_Connection=true;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmplyeeConfigration());
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<Emplyee>()
            //    .HasOne(E => E.Department)
            //    .WithOne(D => D.Manager)
            //    .HasForeignKey<Department>(D => D.DepartmentManagerId);


            //modelBuilder.Entity<Emplyee>()
            //    .HasForeignKey<Department>(D => D.DepartmentManagerId)
            //.OnDelete(DeleteBehavior.NoAction)
            //    .HasOne<Department>()
            //    .WithOne()
            //    .IsRequired(true);


            //modelBuilder.Entity<Department>()
            //    .HasMany(D => D.Employees)
            //    .WithOne(E => E.Department);

            //modelBuilder.Entity<Emplyee>()
            //    .HasOne(E => E.Department)
            //    .WithMany(D => D.Employees)
            //    .IsRequired(false)
            //    .HasForeignKey(E => E.DepartmentId);

            modelBuilder.Entity<Course>()
             .HasMany(c => c.studentCourses)
             .WithOne(sc => sc.Course);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.studentCourses)
                .WithOne(sc => sc.Student);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(Sc => new { Sc.StudentId, Sc.CourseId });
            modelBuilder.Entity<EmployeeDepartment>().ToView("EmployeeDepartmentView");

            //modelBuilder.Entity<FullTime>()
            //    .Property(F => F.Salary)
            //    .HasColumnType("decimal (18,3)");

            //modelBuilder.Entity<PartTime>()
            //    .Property(P => P.HourRate)
            //    .HasColumnType("decimal (18,4)");
            //modelBuilder.Entity<FullTime>()
            //    .HasBaseType<Employee>();

            //modelBuilder.Entity<PartTime>()
            //    .HasBaseType<Employee>();



            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Emplyee>? Employees { get; set; }
        public DbSet<Department>? departments { get; set; }
        //public DbSet<Address> Address { get; set; }
        public DbSet<Course> courses { get; set; }
       // public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<Student> students { get; set; } //علشان يعمل table في الداتا عندي 
        //public DbSet<FullTime> FullTimeEmployee { get; set; }
        //public DbSet<PartTime> PartTimeEmplyee { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }

    }
}
