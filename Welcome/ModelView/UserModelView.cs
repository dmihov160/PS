public class UserPasswordModelView
{
    private readonly User _user;

    public UserPasswordModelView(User user)
    {
        _user = user;
    }

    public string Email
    {
        get => _user.Email;
        set => _user.Email = value;
    }

    public string Password
    {
        get => _user.Password;
        set => _user.Password = value;
    }
}

public class UserModelView
{
    private readonly User _user;

    public UserModelView(User User)
    {
        _user = User;
    }

    public string Name
    {
        get => _user.Name;
        set => _user.Name = value;
    }

    public UserType Type
    {
        get => _user.Type;
        set => _user.Type = value;
    } 
}