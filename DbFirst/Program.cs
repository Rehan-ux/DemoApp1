using DbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext dbContext = new NorthwindContext();
            #region
            // //1/Excute Select Statement :From Sql Row ,FromSqlInterPolated
            //int count = 3;
            //var categories = dbContext.Categories.FromSqlRaw("select * from Categories");
            //categories = dbContext.Categories.FromSqlRaw("select top({0})* from categorise", count);

            ////FromSqlInterPolated
            //categories = dbContext.Categories.FromSqlInterpolated($"select * from categories");
            //categories = dbContext.Categories.FromSqlInterpolated($"select top({count})*from Categories");

            ////Excute Dml statment [insert ,Update, delete ]
            ////excuteSqlRow
            //var Result= dbContext.Database.ExecuteSqlRaw("Update categories\r\nest CategoryName ='Hamada'\r\nWhere CategoryId=6 ");
            //Console.WriteLine(Result);

            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item.CategoryId);
            //}


            //var Categories = dbcontext.Categories.ToList();
            //foreach (var item in Categories)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}
            #endregion
            //NorthwindContextProcedures procedures=new NorthwindContextProcedures(dbContext);

            //var Products = procedures.SalesByCategoryAsync("Seafood", "1998").Result;
            //foreach (var item in Products)
            //{
            //    // Console.WriteLine($"{item.ProductName}::{item.TotalPurchase}");
            //    Console.WriteLine(item);
            //}
            //cheack localy first [local=>cache app]

            if (dbContext.Products.Local.Any(p => p.UnitsInStock == 0))
             Console.WriteLine("there is at least one element out stock ");
            else if (dbContext.Products.Any(p => p.UnitsInStock == 0))
                Console.WriteLine("there is at least one element out stock ");
        }
    }
}
    