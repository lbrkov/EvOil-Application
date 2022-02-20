namespace EvOil.Domain.Models;

public class Evaluator : User
{
    public Evaluator()
    {
    }

    public Evaluator(string name, string password, string username) : base(name, password, username)
    {
    }
    public static void EvaluateOil()
    {
    }

}