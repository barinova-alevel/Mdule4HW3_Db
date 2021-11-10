using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Mdule4HW3_Db.Configuration
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(p => p.EmployeeProjectId).IsRequired().HasColumnName("EmployeeProjectId");
            builder.Property(p => p.Rate).IsRequired().HasColumnName("Rate");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate");
            builder.Property(p => p.EmployeeId).IsRequired().HasColumnName("EmployeeId");
            builder.Property(p => p.ProjectId).IsRequired().HasColumnName("ProjectId");

            builder.HasData(new List<EmployeeProject>()
            { 
            new EmployeeProject() { EmployeeProjectId = 1, Rate = 25M, StartedDate = new DateTime(2019,05,09,9,15,0), EmployeeId = 1, ProjectId = 1 },
            new EmployeeProject() { EmployeeProjectId = 2, Rate = 15M, StartedDate = new DateTime(2016,05,09,9,15,0), EmployeeId = 1, ProjectId = 1 },
            new EmployeeProject() { EmployeeProjectId = 3, Rate = 250M, StartedDate = new DateTime(2018,05,09,9,15,0), EmployeeId = 1, ProjectId = 1 }
            });
        }
    }
}
