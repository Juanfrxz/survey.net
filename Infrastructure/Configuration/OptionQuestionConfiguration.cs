using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class OptionQuestionConfiguration : IEntityTypeConfiguration<OptionQuestion>
    {
        public void Configure(EntityTypeBuilder<OptionQuestion> builder)
        {
            builder.ToTable("option_questions");

            builder.HasKey(oq => oq.Id);

            builder.Property(oq => oq.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.HasOne(oq => oq.Option)
                .WithMany()
                .HasForeignKey(oq => oq.OptionId);

            builder.HasOne(oq => oq.CategoriesCatalog)
                .WithMany(cc => cc.OptionQuestions)
                .HasForeignKey(oq => oq.OptioncatalogId);
        }
    }
}