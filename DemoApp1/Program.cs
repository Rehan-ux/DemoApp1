using DemoApp1.DbContexts;
using DemoApp1.InheritanceExamaple.Entities;
using DemoApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DemoApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //using CompanyDbcontext dbcontext = new CompanyDbcontext();
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
            //foreach (var item in dbcontext.EmployeeDepartments)
            //{
            //    Console.WriteLine($"Empolyee :{item.EmpName},Department:{item.DeptName}");
            //}
            #endregion
            #region session 5 join[inner]
            //query syntax
            //var result = from E in dbcontext.Employees
            //             join D in dbcontext.departments
            //             on E.DepartmentId equals D.DepartmentId
            //             where E.Salary >= 5000
            //             select new
            //             {
            //                 EmpName = E.Name,
            //                 DeptName = D.Name

            //             };
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //fluentSyntax
            //var result = dbcontext.Employees.Join(dbcontext.departments, E => E.DepartmentId, D => D.DepartmentId,
            //                   (E, D) => new
            //                   {
            //                       EmpName = E.Name,
            //                       DeptName = D.Name,
            //                       salary =E.Salary,

            //                   }).Where(A => A.salary > 3000);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region GroupJoin_ Left outer jion 
            //var Result = dbcontext.departments.GroupJoin(dbcontext.Employees, D => D.DepartmentId,
            //          E => E.DepartmentId, (D, E) => new
            //          {
            //              Department = D,
            //              Employees = E
            //          });

            //Query
            //var Result = from D in dbcontext.departments
            //             join E in dbcontext.Employees
            //             on D.DepartmentId equals E.DepartmentId into Groups
            //             select new
            //             {
            //                 Department = D,
            //                 Employees = Groups
            //             };

            //foreach (var result in Result)
            //{
            //    Console.WriteLine($"DeptName = {result.Department.Name}");
            //    foreach(var item in result.Employees)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}


            //Example2

            //var Result = dbcontext.departments.GroupJoin(dbcontext.Employees, D => D.DepartmentId, E => E.DepartmentId,
            //               (Department, Emplyee) => new
            //               {
            //                   Department =Department,
            //                   Emplyees = Emplyee

            //               }).Where(A=>A.Emplyees.Count()>1);

            //Query
            //var Result = from D in dbcontext.departments
            //             join E in dbcontext.Employees
            //             on D.DepartmentId equals E.DepartmentId into Groups
            //             select new
            //             {
            //                 Department = D,
            //                 Emplyees = Groups
            //             } into Group
            //             where Group.Emplyees.Count() > 1
            //             select Group;

            //foreach (var item  in Result)
            //{
            //    Console.WriteLine(item.Department.Name);
            //    foreach(var item3 in item.Emplyees)
            //    {
            //        Console.WriteLine(item3.Name);
            //    }
            //}
            //Ea\xample 3 leftJoin
            //var Result = dbcontext.departments.LeftJoin(dbcontext.Employees, D => D.DepartmentId, E => E.DepartmentId
            //            (D, E) => new
            //            {
            //                 Dept=D,
            //                 Emp=E
            //            }); 
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region [Group Join Right outer Join]
            //var result = dbcontext.Employees.GroupJoin(dbcontext.departments ,E=>E.DepartmentId,D=>D.DepartmentId,
            //                   (D, E) => new
            //                   {
            //                       Department = D,
            //                       Empolyees=E

            //                   });
            //foreach (var item1 in result)
            //{
            //    Console.WriteLine(item1.Empolyees);
            //    foreach(var item2 in item1.Department.EmpName)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}
            #endregion
            #region  Cross Join
            //var result = from E in dbcontext.Employees
            //             from D in dbcontext.departments
            //             select new
            //             {
            //                 E.Name,
            //                deptName= D.Name
            //             };
            ////fluent
            //result = dbcontext.Employees.SelectMany(E=>dbcontext.departments.Select(D => new
            //{
            //    E.Name,
            //    deptName=D.Name
            //}));
            //foreach (var  item in result)
            //{
            //    Console.WriteLine(item);   
            //}
            #endregion
            #region
            
            #endregion
        }
    }
}
            