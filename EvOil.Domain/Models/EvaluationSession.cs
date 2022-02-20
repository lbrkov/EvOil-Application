using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System;
using EvOil.Domain.Enumerations;

namespace EvOil.Domain.Models;

public class EvaluationSession
{
    public EvaluationSession(TypeOfSession typeOfSession, ICollection<string> oilcodenames)
    {
        TypeOfSession = typeOfSession;
        OilCodeNames = oilcodenames;
    }

    public EvaluationSession()
    {
    }

    public Evaluation CreateEvaluation()
    {
        return new Evaluation();
    }
    [NotMapped]
    public ICollection<string> OilCodeNames { get; set; } = new List<string>();
    public int Id { get; set; }
    public TypeOfSession TypeOfSession { get; }
    public virtual ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
}