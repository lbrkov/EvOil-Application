using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvOil.Persistence.Configurations;
internal class EvaluationConfiguration : IEntityTypeConfiguration<Evaluation>
{
    public void Configure(EntityTypeBuilder<Evaluation> builder)
    {
        _ = builder.HasKey(evaluation => new { evaluation.UserId, evaluation.OilId });


    }
}
