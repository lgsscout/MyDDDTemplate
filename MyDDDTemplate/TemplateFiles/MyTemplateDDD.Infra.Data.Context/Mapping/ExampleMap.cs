using $ext_safeprojectname$.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace $safeprojectname$.Mapping
{
    public class ExampleMap : IEntityTypeConfiguration<Example>
    {
        public void Configure(EntityTypeBuilder<Example> builder)
        {
            builder.ToTable("Example")
                .HasKey(b => b.ID);

            builder.Property(b => b.ID)
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(b => b.Description)
                .HasMaxLength(100)
                .IsRequired();

            builder.Ignore(b => b.ValidationResult);
        }
    }
}
