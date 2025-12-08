namespace Tests.Utils
{
    public class LoginTestData
    {
        public required UserData validUser { get; set; }
        public required UserData invalidUser { get; set; }
    }

    public class UserData
    {
        public required string username { get; set; }
        public required string password { get; set; }
    }
}
