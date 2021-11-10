using Mdule4HW3_Db.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Mdule4HW3_Db
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", true, true);
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());

            modelBuilder.Entity<Employee>().HasOne(d => d.Office)
                .WithMany(p => p.employees)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>().HasOne(t => t.Title)
                .WithMany(p1 => p1.employees)
                .HasForeignKey(t => t.TitleId)
                .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Employee>()
            //    .HasMany<Project>(pr => pr.EmployeeProjects)
            //    .WithMany(c => c.Employees)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("EmployeeId");
            //        cs.MapRightKey("ProjectId");
            //        cs.ToTable("EmployeeProject");
            //    });

        }
    }
}
