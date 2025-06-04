using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class SumaryOptionConfiguration : IEntityTypeConfiguration<SumaryOption>
    {
        public void Configure(EntityTypeBuilder<SumaryOption> builder)
        {
            builder.ToTable("sumaryoptions");

            builder.HasKey(so => so.Id);

            builder.Property(so => so.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(so => so.CodeNumber)
                .HasMaxLength(20);

            builder.Property(so => so.Valuerta)
                .IsRequired();

            builder.HasOne(so => so.Survey)
                .WithMany(s => s.SumaryOptions)
                .HasForeignKey(so => so.IdSurvey);

            builder.HasOne(so => so.Question)
                .WithMany(q => q.SumaryOptions)
                .HasForeignKey(so => so.Idquestion);
        }
    }
}