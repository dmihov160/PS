using System.Windows.Controls;
using DataLayer.Model;
using DataLayer.Services;

namespace UIStudentUser.Component.User;

public partial class UserList : UserControl
{
    private UserService _userService;
    
    public UserList()
    {
        InitializeComponent();
        _userService = new UserService();
        InitUsers();
        var usersAll = _userService.GetAllUsers();
        users.DataContext = usersAll;
    }

    private void InitUsers()
    {
        for (int i = 1; i <= 10; i++)
        {
            DatabaseUser user = new DatabaseUser();
            user.Name = "Ivan Ivanov Ivanov";
            user.Email = "ivan@gmail.com";
            user.Password = "1234";
            user.FacultyNumber = "121220160";
            _userService.InsertUser(user);
        }
        _userService.SaveContext();
    }
}