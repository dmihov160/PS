using Welcome.Encryption;

public class User
{
    private string _password;

    public User(string Name, UserType Type, string email, string password)
    {
        this.Name = Name;
        this.Type = Type;
        Email = email;
        Password = password;
    }

    public string Name { get; set; }

    public string Password
    {
        get => _password;
        set => _password = PasswordEncryptor.EncryptPassword(value);
    }

    public UserType Type { get; set; }

    public string FacultyNumber { get; set; }
    public string Email { get; set; }
}