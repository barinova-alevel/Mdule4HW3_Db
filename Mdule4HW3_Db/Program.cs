using Mdule4HW3_Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySolution;
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

            /* var joinThreeTables = (from o in applicationContext.Offices
                                   join e in applicationContext.Employees on o.OfficeId equals e.OfficeId into OfficesEmployees
                                   from oe in OfficesEmployees.DefaultIfEmpty()
                                   join t in applicationContext.Titles on oe.TitleId equals t.TitleId into result
                                   from re in result.DefaultIfEmpty()
                                   select new { Id = o.OfficeId, EmployeeName = oe.FirstName, TitlaName = re.Name })
                                   .ToList(); */

            /* var dateDiff = applicationContext.Employees.Select(e => new { dateDifference = EF.Functions.DateDiffDay(e.HiredDate, DateTime.UtcNow) }).ToList(); */

            /* var employees = applicationContext.Employees.ToList();
            employees[0].FirstName = "UpdatedFirstName1";
            employees[1].HiredDate = new DateTime (2008, 5, 1, 8, 30, 52);
            applicationContext.Employees.Update(employees[0]);
            applicationContext.Employees.Update(employees[1]); */

            /* var newEmployee = new Employee() { FirstName = "Samanta", LastName = "Richardson", HiredDate = new DateTime(2008, 5, 1, 8, 30, 52), DateOfBirth = new DateTime (1994, 7, 1, 8, 30, 52), OfficeId = 2, TitleId = 2};
            applicationContext.Employees.Add(newEmployee); */

            /* var title = applicationContext.Employees
                .GroupBy(e => e.Title.Name)
                .Select(x => x.Key)
                .Where(k => !EF.Functions.Like(k, "%a%"))
                .ToList(); */

            var joinTables = applicationContext.Employees
             .Include(i => i.Office)
                .ThenInclude(i => i.Employees)
                    .ThenInclude(i => i.EmployeeProjects)
                .Include(i => i.Office)
                    .ThenInclude(i => i.Employees)
                        .ThenInclude(i => i.Title)
                .Include(i => i.Title)
                .ToList();

            applicationContext.SaveChanges();
        }
    }
}
