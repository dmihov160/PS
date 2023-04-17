using System;

namespace Welcome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var User = new User("Damyan", UserType.ADMIN, "dmihov@tu-sofia.bg", "12345");
            var UserModelView = new UserModelView(User);
            var UserView = new UserView(UserModelView);
            var UserPasswordModelView = new UserPasswordModelView(User);
            var UserPasswordView = new UserPasswordView(UserPasswordModelView);
            UserView.Display();
            UserPasswordView.Display();
            Console.ReadKey();
        }
    }
}