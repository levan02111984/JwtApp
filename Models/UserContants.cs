namespace JwtApp.Models
{
    public static class UserContants
    {
        public static List<UserModel> Users = new List<UserModel>
        {
            new UserModel
            {
                UserName = "levan",
                Password = "pass1234",
                EmailAddress = "levan02111984@gmail.com",
                Role = "Admin",
                Surname = "Le",
                GivenName = "Van"
            },
            new UserModel
            {
                UserName = "lamanh",
                Password = "pass1234",
                EmailAddress = "lam.anh@example.com",
                Role = "User",
                Surname = "Lam",
                GivenName = "Anh"
            },
            new UserModel
            {
                UserName = "anhsa",
                Password = "pass1234",
                EmailAddress = "Anh.sa@example.com",
                Role = "Moderator",
                Surname = "Anh",
                GivenName = "Sa"
            }
        };
    }
}
