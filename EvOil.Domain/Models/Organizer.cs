
namespace EvOil.Domain.Models;
public class Organizer : User
{
    private ICollection<Oil> Oils { get; set; } = new List<Oil>();
    private static bool _isSessionDone = false;

    /// <summary>
    /// EF constructor
    /// </summary>
    private Organizer()
    {

    }

    public Organizer(string name, string password, string username) : base(name, password, username)
    {

    }

    public void AddOil(string fullname, string codename)
    {
        if (Oils is null)
        {
            throw new ArgumentNullException(nameof(Oils));
        }
        else
        {
            Oils.Add(new Oil() { FullName = fullname, CodeName = codename });
        }
    }
    public ICollection<string> GetOilCodeNames()
    {
        if (Oils.Count == 0)
            throw new ArgumentNullException(nameof(Oils));

        ICollection<string> oilcodenames = new List<string>();
        foreach (var oil in Oils)
            oilcodenames.Add(oil.CodeName);
        return oilcodenames;
    }

    public EvaluationSession CreateEvaluationSession()
    {
        if (new User().GetType() == typeof(Trainee))
        {
            return new EvaluationSession(Enumerations.TypeOfSession.Training, GetOilCodeNames());
        }
        else
        {
            return new EvaluationSession(Enumerations.TypeOfSession.Evaluation, GetOilCodeNames());
        }
    }
    public void SendOilToEvaluate()
    {

    }
    public static void GenerateSessionReport()
    {

    }
    public static void ConcludeEvaluationSession()
    {
        _isSessionDone = true;
    }

}