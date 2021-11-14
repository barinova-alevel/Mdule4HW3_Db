using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MySolution.Configuration
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(p => p.TitleId).HasColumnName("TitleId");
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);

            builder.HasData(new List<Title>()
            {
                new Title() { TitleId = 1, Name = "Title1"},
                new Title() { TitleId = 2, Name = "Title2"},
                new Title() { TitleId = 3, Name = "Title3"}
                           });
        }

    }

}
