using DataLayer.Database;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories;

public class UserRepository
{
    private UserContext _userContext;

    private bool _disposed;

    private static UserRepository _instance;

    private UserRepository(UserContext userContext)
    {
        _userContext = userContext;
    }

    public static UserRepository getInstance()
    {
        if (_instance == null)
        {
            _instance = new UserRepository(new UserContext());
            return _instance;
        }

        return _instance;
    }

    public IEnumerable<DatabaseUser> GetUsers()
    {
        return _userContext.Users.ToList();
    }

    public DatabaseUser FindUserById(int id)
    {
        return _userContext.Users.Find(id);
    }

    public void InsertUser(DatabaseUser user)
    {
        _userContext.Users.Add(user);
    }

    public void DeleteUser(int id)
    {
        DatabaseUser user = _userContext.Users.Find(id);
        _userContext.Users.Remove(user);
    }

    public void Save()
    {
        _userContext.SaveChanges();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _userContext.Dispose();
            }
        }
        this._disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}