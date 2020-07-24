using SeparationExample.Library.BusinessLogic.Users;
using System;

namespace SeparationExample.GUI
{
    internal class Program
    {
        private static void Main()
        {
            // business logic
            var user = new User();
            user.Username = "Voiden";
            Console.WriteLine($"Logging in as {user.Username}");

            user.Password = "passworD123";
            Console.WriteLine($"Trying password - {user.Password}");

            var login = new Login();
            var response = login.VerifyLogin(user);

            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}