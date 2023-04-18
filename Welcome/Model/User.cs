using System.ComponentModel.DataAnnotations.Schema;
using Welcome.Encryption;

public class User
{
    private string _password;

    public User(string Name, string email, string password)
    {
        this.Name = Name;
        Email = email;
        Password = password;
    }
    
    public User(){}
    
    [Column("FullName")]
    public string Name { get; set; }

    [Column("Pass")]
    public string Password
    {
        get => _password;
        set => _password = PasswordEncryptor.EncryptPassword(value);
    }


    public string? FacultyNumber { get; set; }
    public string? Email { get; set; }
}