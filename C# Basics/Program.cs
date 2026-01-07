// Constructor with parameters
User user = new User(1, "Sanele", "sanele@example.com");

Console.WriteLine($"User: {user.UserName}, Email: {user.Email}");

//User Class with Constructor
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }

    public User(int id, string userName, string email)
    {
        Id = id;
        UserName = userName;
        Email = email;
    }
}
