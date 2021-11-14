using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySolution.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace MySolution.DataAccess.Configuration
{
    public class ClientConfiguration
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("First Name").HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(p => p.FirstOrder).IsRequired().HasColumnName("ClientSince");
            builder.Property(p => p.Email).HasColumnName("DateOfBirdth");
            builder.Property(p => p.ProjectId).IsRequired().HasColumnName("ProjectId");

            builder.HasOne(r => r.Project)
                .WithMany(c => c.clients)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Client>()
            {
                new Client() { Id = 1, FirstName = "Client1", LastName = "LastNameClient 2", FirstOrder = new DateTime(2020,05,09,9,15,0), Email = "mail1@mail.se"},
                new Client() { Id = 2, FirstName = "Client2", LastName = "LastNameClient 2", FirstOrder = new DateTime(2020,05,09,9,15,0), Email = "mail2@mail.se"},
                new Client() { Id = 3, FirstName = "Client3", LastName = "LastNameClient 2", FirstOrder = new DateTime(2020,05,09,9,15,0), Email = "mail3@mail.se"},
                new Client() { Id = 4, FirstName = "Client4", LastName = "LastNameClient 2", FirstOrder = new DateTime(2020,05,09,9,15,0), Email = "mail4@mail.se"},
                new Client() { Id = 5, FirstName = "Client5", LastName = "LastNameClient 2", FirstOrder = new DateTime(2020,05,09,9,15,0), Email = "mail5@mail.se"},

            });
           
        }
    }
}
