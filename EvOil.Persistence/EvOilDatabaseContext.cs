using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore;
using EvOil.Persistence.Configurations;
using EvOil.Business;

namespace EvOil.Persistence;

public class EvOilDatabaseContext : DbContext, IEvOilDatabaseContext
{
    public EvOilDatabaseContext(DbContextOptions<EvOilDatabaseContext> options) : base(options)
    {
    }
    public DbSet<Evaluation> Evaluations { get; set; } = null!;
    public DbSet<EvaluationSession> EvaluationSessions { get; set; } = null!;
    public DbSet<Oil> Oils { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Organizer> Organizers { get; set; } = null!;
    public DbSet<Evaluator> Evaluators { get; set; } = null!;
    public DbSet<Trainee> Trainees { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        _ = modelBuilder.ApplyConfiguration(new EvaluationConfiguration());
        _ = modelBuilder.ApplyConfiguration(new OilConfiguration());
        _ = modelBuilder.ApplyConfiguration(new UserConfiguration());
        _ = modelBuilder.ApplyConfiguration(new EvaluationSessionConfiguration());

    }

}
