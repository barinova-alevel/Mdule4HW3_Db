using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySolution.DataAccess;
using System;
using System.Linq;

namespace Module4HW3_Db
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));
            dbOptionsBuilder.LogTo(Console.Write);

            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);
            applicationContext.Database.Migrate();

            // 1
            //var threeTables = applicationContext.Clients
            //    .Include(i => i.Projects)
            //    .ThenInclude(i => i.Employees)
            //    .ToList();

            // 2 - don't work
            //var dateDiff = EF.Functions.DateDiffDay(applicationContext.Projects, DateTime.Today);

            // 3 - don't work
            //var cls = applicationContext.Clients.Where(i => i.Email == "newmail@mail1.de");
            //var newClient2 = applicationContext.Clients.Update(cls);


            applicationContext.SaveChanges();
        }
    }
}
