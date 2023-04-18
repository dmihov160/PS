using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Database;

public class DatabaseContext : DbContext
{
    public DbSet<DatabaseUser> Users { get; set; }
    public DbSet<DatabaseStudent> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string dataBaseFile = "Welcome.db";
        string databasePath = Path.Combine(solutionFolder, dataBaseFile);
        optionsBuilder.UseSqlite($"datasource={databasePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();
        var user = new DatabaseUser()
        {
            Id = 1,
            Name = "Damyan Mihov",
            Password = "1323",
            Email = "dmihov@tu-sofia.bg",
            FacultyNumber = "121220160"
        };

        modelBuilder.Entity<DatabaseUser>().HasData(user);
    }
}