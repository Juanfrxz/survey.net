using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("questions");

            builder.HasKey(q => q.Id);

            builder.Property(q => q.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(q => q.QuestionNumber)
                .HasMaxLength(10);

            builder.Property(q => q.ResponseType)
                .HasMaxLength(10);

            builder.Property(q => q.QuestionText)
                .IsRequired();

            builder.HasOne(q => q.Chapter)
                .WithMany(c => c.Questions)
                .HasForeignKey(q => q.ChapterId);
        }
    }
}