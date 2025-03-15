using DemoApp1.DbContexts;
using DemoApp1.InheritanceExamaple.Entities;
using Microsoft.VisualBasic;

namespace DemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbcontext dbcontext = new CompanyDbcontext();
            //using CompanyDbcontext dbcontext = new CompanyDbcontext();
            FullTime full = new FullTime()
            {
                Name = "Maha Ahmed",
                Address = "Giza",
                Age = 24,
                Salary =1_000,
                StartDate = DateTime.Now,
            };
            PartTime partTime = new PartTime()
            {
                Name = "AliMohamed",
                Address = "Cairo",
                Age = 25,
                HourRate = 250,
                CountOfHour = 10
            };
            //Detached
            dbcontext.FullTimeEmployee.Add(full); //add
            dbcontext.PartTimeEmplyee.Add(partTime);
            dbcontext.SaveChanges();
            foreach (var full1 in dbcontext.FullTimeEmployee)
            {
                Console.WriteLine($"EmpName : {full1.Name},Salary{full1.Salary}");
            }
            foreach (var part in dbcontext.PartTimeEmplyee)
            {
                Console.WriteLine($"EmpName : {part.Name},Salary{part.HourRate}");
            }
        }
    }
}
