namespace SeparationExample.Library.BusinessLogic.Users
{
    public class Login
    {
        public bool VerifyLogin(User userToVerify)
        {
            // get users credentials from database
            var userCredentials = new Database.Users.User().GetCredentials();

            if (userToVerify.Password == userCredentials.Password)
            {
                return true;
            }

            // it's wrong so lock the account
            userCredentials.LockAccount();

            return false;
        }
    }
}