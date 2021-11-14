using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MySolution
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("First Name").HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(p => p.HiredDate).IsRequired().HasColumnName("HiredDate");
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirdth"); ;
            builder.Property(p => p.OfficeId).IsRequired().HasColumnName("OfficeId");
            builder.Property(p => p.TitleId).IsRequired().HasColumnName("TitleId");

            builder.HasOne(t => t.Title)
                .WithMany(e => e.employees)
                .HasForeignKey(t => t.TitleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Office)
                .WithMany(p => p.employees)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Aaron", LastName = "Aronson", HiredDate = new DateTime(2021,05,09,9,15,0), DateOfBirth =new DateTime(2000,05,09,9,15,0), OfficeId = 1, TitleId = 1 },
                new Employee() { Id = 2, FirstName = "Adam",LastName = "Adamson", HiredDate = new DateTime(2021,05,09,9,15,0), DateOfBirth =new DateTime(2000,05,09,9,15,0), OfficeId = 1, TitleId = 1 },
                new Employee() { Id = 3, FirstName = "Devid",LastName = "Devidson", HiredDate = new DateTime(2021,05,09,9,15,0), DateOfBirth =new DateTime(2000,05,09,9,15,0), OfficeId = 2, TitleId = 1 }
            });
        }

    }
}
