using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class SubQuestionConfiguration : IEntityTypeConfiguration<SubQuestion>
    {
        public void Configure(EntityTypeBuilder<SubQuestion> builder)
        {
            builder.ToTable("sub_questions");

            builder.HasKey(sq => sq.Id);

            builder.Property(sq => sq.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(sq => sq.SubQuestionNumber)
                .HasMaxLength(10);

            builder.Property(sq => sq.SubQuestionText)
                .IsRequired();

            builder.HasOne(sq => sq.Question)
                .WithMany(q => q.SubQuestions)
                .HasForeignKey(sq => sq.SubQuestionId);
        }
    }
}