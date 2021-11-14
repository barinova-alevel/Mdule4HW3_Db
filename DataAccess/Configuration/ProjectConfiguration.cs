using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MySolution.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(e => e.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").IsRequired();
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate");
            builder.Property(p => p.ClientId).IsRequired().HasColumnName("ClientId");

            builder.HasData(new List<Project>()
            {
                new Project() { ProjectId = 1, Name = "Project1", Budget = 1005.5M, StartedDate = new DateTime(2019,05,09,9,15,0)},
                new Project() { ProjectId = 2, Name = "Project2", Budget = 20000.5M, StartedDate = new DateTime(2021,05,09,9,15,0)},
                new Project() { ProjectId = 3, Name = "Project3", Budget = 4000, StartedDate = new DateTime(2018,07,10,10,25,0)},
                new Project() { ProjectId = 4, Name = "Project4", Budget = 3500, StartedDate = new DateTime(2018,07,10,10,25,0)},
                new Project() { ProjectId = 5, Name = "Project5", Budget = 8700, StartedDate = new DateTime(2019,06,10,10,25,0)},

            });
        }
    }
}
