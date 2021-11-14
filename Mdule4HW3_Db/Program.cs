﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySolution.DataAccess;

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
            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);
            applicationContext.Database.Migrate();
            applicationContext.SaveChanges();
        }
    }
}
