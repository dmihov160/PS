using DataLayer.Model;
using DataLayer.Repositories;

namespace DataLayer.Services;

public class UserService
{
    private UserRepository _userRepository;

    public UserService()
    {
        _userRepository = UserRepository.getInstance();
    }

    public IEnumerable<DatabaseUser> GetAllUsers()
    {
        return _userRepository.GetUsers();
    }

    public DatabaseUser GetUserById(int id)
    {
        return _userRepository.FindUserById(id);
    }

    public void InsertUser(DatabaseUser user)
    {
        _userRepository.InsertUser(user);
    }

    public void DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
    }
    
    public void SaveContext()
    {
        _userRepository.Save();
    }
}