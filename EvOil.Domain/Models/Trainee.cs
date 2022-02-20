namespace EvOil.Domain.Models;
public class Trainee : User
{
    public Trainee()
    {
    }

    public Trainee(string name, string password, string username) : base(name, password, username)
    {
        Name = name;
        Password = password;
    }

}
