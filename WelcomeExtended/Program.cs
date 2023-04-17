using WelcomeExtended.Helpers;
using WelcomeExtended.Others;
using WelcomeExtended.Others;

try
{
    var user = new User("John Smith", UserType.NORMAL, "smith1@gmail.com", "1245");
    

    var viewModel = new UserModelView(user);

    var view = new UserView(viewModel);
    
    view.Display();
    view.DisplayError();
}
catch (Exception e)
{
    Delegates.ActionOnError log = Delegates.Log;
    log(e.Message);
}
finally
{
    Console.WriteLine("Executed finally");
}
