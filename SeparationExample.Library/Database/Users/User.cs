namespace SeparationExample.Library.Database.Users
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsLocked { get; private set; }

        public User GetCredentials()
        {
            return new User { Username = "Voiden", Password = "123" };
        }

        internal void LockAccount()
        {
            this.IsLocked = true;
        }
    }
}