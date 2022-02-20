using System.Data;
namespace EvOil.Domain.Models;
public class Oil
{
    public Oil() { }
    public Oil(string codeName, string fullName)
    {
        CodeName = codeName;
        FullName = fullName;
    }
    public int Id { get; private set; }
    public string CodeName { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public virtual ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    public virtual ICollection<EvaluationSession> EvaluationSessions { get; set; } = new List<EvaluationSession>();
}