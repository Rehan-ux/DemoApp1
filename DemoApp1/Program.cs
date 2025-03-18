using DemoApp1.DbContexts;
using DemoApp1.InheritanceExamaple.Entities;
using DemoApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace DemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using CompanyDbcontext dbcontext = new CompanyDbcontext();
            //using CompanyDbcontext dbcontext = new CompanyDbcontext();
            #region
            //FullTime full = new FullTime()
            //{
            //    Name = "Maha Ahmed",
            //    Address = "Giza",
            //    Age = 24,
            //    Salary =1_000,
            //    StartDate = DateTime.Now,
            //};
            //PartTime partTime = new PartTime()
            //{
            //    Name = "AliMohamed",
            //    Address = "Cairo",
            //    Age = 25,
            //    HourRate = 250,
            //    CountOfHour = 10
            //};
            ////Detached
            //dbcontext.FullTimeEmployee.Add(full); //add
            //dbcontext.PartTimeEmplyee.Add(partTime);
            //dbcontext.SaveChanges();
            //foreach (var full1 in dbcontext.FullTimeEmployee)
            //{
            //    Console.WriteLine($"EmpName : {full1.Name},Salary{full1.Salary}");
            //}
            //foreach (var part in dbcontext.PartTimeEmplyee)
            //{
            //    Console.WriteLine($"EmpName : {part.Name},Salary{part.HourRate}");
            //}
            #endregion
            #region Explicit loading Session 4
            //var emplyee = (from E in dbcontext.Employees
            //              where E.EmpId == 1
            //              select E).FirstOrDefault();
            ////هرجع الداتا بتاعت الdepartment
            ////علشان يرجع هينفذ عندي 2 request /Depment واحد بتاع ال
            ////وواحد يجيب الداتا بتاع الemplyee
            ////ودا يعتبر عيب 
            ////Extra trip 
            //dbcontext.Entry(emplyee).Reference(E=>E.Department).Load();
            //Console.WriteLine($"EmpName :{emplyee?.EmpName},DeptName{emplyee?.Department?.Name}");


            //var department =( from D in dbcontext.departments
            //                 where D.DepartmentId == 1
            //                 select D).FirstOrDefault();
            //dbcontext.Entry(department).Collection(D=>D.Employees).Load();
            //Console.WriteLine($"DeptName :{department?.Name}");
            //foreach(var emp in department?.Employees)
            //{
            //    Console.WriteLine($"EmpName:{emp.EmpName}");
            //}
            #endregion
            #region EagerLoading
            //var emplyee = (from E in dbcontext.Employees.Include(E=>E.Department)
            //               where E.EmpId == 1
            //               select E).FirstOrDefault();
            //Console.WriteLine($"EmpName :{emplyee?.EmpName},DeptName{emplyee?.Department?.Name}");

            //var department = (from D in dbcontext.departments.Include(D=>D.Employees)
            //                  where D.DepartmentId == 1
            //                  select D).FirstOrDefault();

            //Console.WriteLine($"DeptName :{department?.Name}");
            //foreach (var emp in department?.Employees)
            //{
            //    Console.WriteLine($"EmpName:{emp.EmpName}");
            //}
            #endregion
            #region lazy loading
            //var emplyee = (from E in dbcontext.Employees.Include(E => E.Department)
            //               where E.EmpId == 1
            //               select E).FirstOrDefault();
            //Console.WriteLine($"EmpName :{emplyee?.EmpName},DeptName{emplyee?.Department?.Name}");

            //var department = (from D in dbcontext.departments.Include(D => D.Employees)
            //                  where D.DepartmentId == 1
            //                  select D).FirstOrDefault();

            //Console.WriteLine($"DeptName :{department?.Name}");
            //foreach (var emp in department?.Employees)
            //{
            //    Console.WriteLine($"EmpName:{emp.EmpName}");
            //}
            #endregion
            #region
            //var emplyee=(from E in dbcontext.Employees
            //            where E.EmpId==2
            //            select E).FirstOrDefault();
            //Console.WriteLine(dbcontext.Entry(emplyee).State);
            #endregion
            #region Mapping
            //var Result = dbcontext.EmployeeDepartments.FromSqlRaw("Select * from EmployeeDepartmentView");
            foreach (var item in dbcontext.EmployeeDepartments)
            {
                Console.WriteLine($"Empolyee :{item.EmpName},Department:{item.DeptName}");
            }
            #endregion
        }
    }
}
