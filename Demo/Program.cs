using Demo.Contexts;
using Demo.Entities;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session 01
            //EnterpriseDbContext dbContext = new EnterpriseDbContext();
            //// dbContexet.Database.EnsureCreated();
            ////Second way Migration To Database => EF => C# Code => Sql statment
            //// 1- Code
            ////dbContexet.Database.Migrate(); //Applay ups of all Migrations that not Apllyed

            //// 2- Package Manager Console
            #endregion

            #region Session 02
            #region Connection
            //EnterpriseDbContext dbContext = new EnterpriseDbContext();
            //try
            //{
            //    //CRUD operation
            //}
            //finally
            //{
            //    dbContext.Dispose();
            //}
            //--------------------- Syntax Suger => tryf
            //using (EnterpriseDbContext dbContext = new EnterpriseDbContext()) ;
            //{

            //}
            //--------------------- Syntax Suger
            using EnterpriseDbContext dbContext = new EnterpriseDbContext();
            #endregion

            Employee Emp01 = new Employee() {
                Name = "Mohamed",
                Age = 23,
                Salary = 10000,
                Email = "Mohamed@gmail.com",
                Phone = "01010112908",
                Password = "Mohamed123"
            };
            Employee Emp02 = new Employee()
            {
                Name = "Nourhan",
                Age = 22,
                Salary = 10000,
                Email = "Nourhan@gmail.com",
                Phone = "0123343434",
                Password = "Nourhan"
            };
            Employee Emp03 = new Employee()
            {
                Name = "h",
                Age = 22,
                Salary = 10000,
                Email = "h@gmail.com",
                Phone = "0123555554",
                Password = "h123"
            };
            #region CRUD operations
            #region Insert
            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //Console.WriteLine(dbContext.Entry(Emp02).State);

            //dbContext.Employees.Add(Emp01);
            //dbContext.Employees.Add(Emp02);
            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //Console.WriteLine(dbContext.Entry(Emp02).State);
            //dbContext.Add(Emp02);
            //dbContext.Set<Employee>().Add(Emp01);
            //dbContext.Entry(Emp01).State == EntiteState.Added;
            #endregion

            #region Read / Retreve
            //var Employee = (from E in dbContext.Employees
            //                where E.EmpId == 2
            //                select E).FirstOrDefault();
            //Console.WriteLine(Employee?.Name ?? "Not found");
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion

            #region Update
            //var Employee = ( from E in dbContext.Employees
            //                 where E.EmpId == 2
            //                 select E ).FirstOrDefault();
            //Employee.Name = "Habibi";
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion

            #region Delete
            //dbContext.Employees.Add(Emp03);
            //dbContext.SaveChanges();

            //var Employee = (from E in dbContext.Employees
            //                where E.EmpId == 3
            //                select E).FirstOrDefault();

            //dbContext.Employees.Remove(Employee);
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion
            #endregion
            #endregion
        }
    }
}
