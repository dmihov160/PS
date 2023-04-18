using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Database;

public class StudentContext : DbContext
{
    public DbSet<DatabaseStudent> DatabaseStudents { get; set; }
    
    public StudentContext()
    {
        this.Database.SetConnectionString("Server=localhost\\SQLEXPRESS;Database=StudentInfoDatabase;Trusted_Connection=True;Encrypt=False");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StudentInfoDatabase;Trusted_Connection=True;Encrypt=False",
            options => options.EnableRetryOnFailure());
    }
}