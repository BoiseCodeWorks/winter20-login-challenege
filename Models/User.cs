namespace loginapp.Models
{
  public class User
  {
    public User(string name, string password)
    {
      Name = name;
      Password = password;

    }
    public string Name { get; set; }
    public string Password { get; }

    public bool ValidatePassword(string input)
    {
      return input == Password;
    }
  }
}