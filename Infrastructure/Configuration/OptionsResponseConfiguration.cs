using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class OptionsResponseConfiguration : IEntityTypeConfiguration<OptionsResponse>
    {
        public void Configure(EntityTypeBuilder<OptionsResponse> builder)
        {
            builder.ToTable("options_response");

            builder.HasKey(or => or.Id);

            builder.Property(or => or.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(or => or.OptionText)
                .IsRequired();
        }
    }
}