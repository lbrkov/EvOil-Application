using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvOil.Persistence.Configurations;

public class OilConfiguration : IEntityTypeConfiguration<Oil>
{
    public void Configure(EntityTypeBuilder<Oil> builder)
    {
        builder.Property(oil => oil.CodeName)
                  .HasMaxLength(50);
        builder.Property(oil => oil.FullName)
                  .HasMaxLength(50);
        builder.HasIndex(oil => oil.CodeName).IsUnique();

    }
}
