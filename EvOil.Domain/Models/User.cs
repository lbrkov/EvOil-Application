namespace EvOil.Domain.Models;
public class User
{
    public User() { }
    public User(string name, string password, string username)
    {
        Name = name;
        Password = password;
        Username = username;
    }
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public virtual IEnumerable<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
}