using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MySolution.Configuration
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId");
            builder.Property(p => p.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
            builder.Property(p => p.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);

            builder.HasData(new List<Office>()
            {
                new Office() { OfficeId = 1, Title = "CityOffice", Location = "Address 1"},
                new Office() { OfficeId = 2, Title = "CountrySideOffice", Location = "Address 2"},
                new Office() { OfficeId = 3, Title = "OneMoreCountrySideOffice", Location = "Address 3"},
                            });
        }
    }
}
