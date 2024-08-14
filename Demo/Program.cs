using Demo.Contexts;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseDbContext dbContext = new EnterpriseDbContext();
            // dbContexet.Database.EnsureCreated();
            //Second way Migration To Database => EF => C# Code => Sql statment
            // 1- Code
            //dbContexet.Database.Migrate(); //Applay ups of all Migrations that not Apllyed

            // 2- Package Manager Console
        }
    }
}
