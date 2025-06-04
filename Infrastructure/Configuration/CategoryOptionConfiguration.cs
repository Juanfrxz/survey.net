using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CategoryOptionConfiguration : IEntityTypeConfiguration<CategoryOption>
    {
        public void Configure(EntityTypeBuilder<CategoryOption> builder)
        {
            builder.ToTable("category_options");

            builder.HasKey(co => co.Id);

            builder.Property(co => co.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.HasOne(co => co.CategoriesCatalog)
                .WithMany(cc => cc.CategoryOptions)
                .HasForeignKey(co => co.CategoriesOptionsId);

            builder.HasOne(co => co.OptionsResponse)
                .WithMany(or => or.CategoryOptions)
                .HasForeignKey(co => co.CatalogoptionsId);
        }
    }
}