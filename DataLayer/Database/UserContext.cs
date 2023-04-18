using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Database;

public class UserContext : DbContext
{
    public DbSet<DatabaseUser> Users { get; set; }
    
    public UserContext()
    {
        this.Database.SetConnectionString("Server=localhost\\SQLEXPRESS;Database=StudentInfoDatabase;Trusted_Connection=True;Encrypt=False");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StudentInfoDatabase;Trusted_Connection=True;Encrypt=False",
            options => options.EnableRetryOnFailure());
    }
}