using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Mdule4HW3_Db
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.Id);
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(p => p.HiredDate).IsRequired().HasColumnName("HiredDate");
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth");
            builder.Property(p => p.OfficeId).IsRequired().HasColumnName("OfficeId");
            builder.Property(p => p.TitleId).IsRequired().HasColumnName("TitleId");

            builder.HasData(new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Aaron", LastName = "Aronson", HiredDate = new DateTime(2021,05,09,9,15,0), DateOfBirth =new DateTime(2000,05,09,9,15,0), OfficeId = 1, TitleId = 1 },
                new Employee() { Id = 2, FirstName = "Adam",LastName = "Adamson", HiredDate = new DateTime(2021,05,09,9,15,0), DateOfBirth =new DateTime(2000,05,09,9,15,0), OfficeId = 1, TitleId = 1 },
                new Employee() { Id = 3, FirstName = "Devid",LastName = "Devidson", HiredDate = new DateTime(2021,05,09,9,15,0), DateOfBirth =new DateTime(2000,05,09,9,15,0), OfficeId = 2, TitleId = 1 }
            });
        }

    }
}
