namespace EvOil.Business.DataTransferObjects;

public class UserDto
{
    public UserDto(string name, string username)
    {
        Name = name;
        Username = username;
    }
    public string Name { get; set; } = null!;
    public string Username { get; set; } = null!;

}
