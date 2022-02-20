using System.Threading;
using System.Threading.Tasks;
using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EvOil.Business;
public interface IEvOilDatabaseContext
{
    public DbSet<User> Users { get; }
    public DbSet<Oil> Oils { get; }
    public DbSet<EvaluationSession> EvaluationSessions { get; }
    public DbSet<Evaluation> Evaluations { get; }
    public DbSet<Organizer> Organizers { get; }
    public DbSet<Evaluator> Evaluators { get; }
    public DbSet<Trainee> Trainees { get; set; }
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}
