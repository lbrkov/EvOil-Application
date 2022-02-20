using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvOil.Persistence.Configurations;
internal class EvaluationSessionConfiguration : IEntityTypeConfiguration<EvaluationSession>
{
    public void Configure(EntityTypeBuilder<EvaluationSession> builder)
    {
        _ = builder.Property(evaluationsession => evaluationsession.TypeOfSession).HasColumnName("Type of session");

    }
}