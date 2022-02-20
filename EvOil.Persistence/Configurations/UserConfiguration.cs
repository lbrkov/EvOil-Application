using System.Reflection.Metadata;
using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EvOil.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        _ = builder.Property(user => user.Name)
                   .HasMaxLength(50);
        _ = builder.Property(user => user.Username)
                   .HasMaxLength(50);
        _ = builder.HasIndex(user => user.Username)
                   .IsUnique();
        _ = builder.Ignore(user => user.Password);
        _ = builder.HasDiscriminator<string>("Type of User")
                    .HasValue<Organizer>("Organizer")
                    .HasValue<Evaluator>("Evaluator")
                    .HasValue<Trainee>("Trainee");
    }
}
