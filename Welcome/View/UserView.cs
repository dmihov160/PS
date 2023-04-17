using System;

public class UserPasswordView
{
    private readonly UserPasswordModelView _userPasswordModelView;

    public UserPasswordView(UserPasswordModelView modelView)
    {
        _userPasswordModelView = modelView;
    }

    public string Email 
    {
        get => _userPasswordModelView.Email;
        set => _userPasswordModelView.Email = value;
    }

    public string Password
    {
        get => _userPasswordModelView.Password;
        set => _userPasswordModelView.Password = value;
    }

    public void Display()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("Email: " + _userPasswordModelView.Email);
        Console.WriteLine("Password: " + _userPasswordModelView.Password);
    }
}

public class UserView
{
    private readonly UserModelView _userModelView;

    public UserView(UserModelView UserModelView)
    {
        _userModelView = UserModelView;
    }

    public void Display()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("User: " + _userModelView.Name);
        Console.WriteLine("Role: " + _userModelView.Type);
    }

    public void DisplayError()
    {
        throw new Exception("Error!");
    }
}
