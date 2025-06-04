using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("chapters");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(c => c.ChapterNumber)
                .HasMaxLength(50);

            builder.Property(c => c.ChapterTitle)
                .IsRequired();

            builder.HasOne(c => c.Survey)
                .WithMany(s => s.Chapters)
                .HasForeignKey(c => c.SurveyId);
        }
    }
}