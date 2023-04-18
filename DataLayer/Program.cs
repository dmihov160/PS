using DataLayer.Database;
using DataLayer.Model;

using (var context = new DatabaseContext())
{
    context.Database.EnsureCreated();
    context.Add<DatabaseUser>(new DatabaseUser()
    {
        Name = "user",
        Email = "user@email.com",
        FacultyNumber = "121220xxx",
        Password = "1234",
    });
    context.SaveChanges();
    var users = context.Users.ToList();
    Console.ReadKey();
}