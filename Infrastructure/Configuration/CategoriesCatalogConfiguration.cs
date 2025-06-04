using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CategoriesCatalogConfiguration : IEntityTypeConfiguration<CategoriesCatalog>
    {
        public void Configure(EntityTypeBuilder<CategoriesCatalog> builder)
        {
            builder.ToTable("categories_catalog");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasMaxLength(255);
        }
    }
}