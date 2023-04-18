using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model;
[Table("DatabaseUser")]
public class DatabaseUser : User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public DatabaseUser(int id, string Name, string email, string password) : base(Name, email, password)
    {
        Id = id;
    }

    public DatabaseUser() : base()
    {
    }
}