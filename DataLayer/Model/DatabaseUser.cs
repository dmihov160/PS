using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model;

public class DatabaseUser : User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public DatabaseUser(int id, string Name, UserType Type, string email, string password) : base(Name, Type, email, password)
    {
        Id = id;
    }

    public DatabaseUser() : base()
    {
    }
}