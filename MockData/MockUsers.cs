using Microsoft.AspNetCore.Identity;
using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.MockData
{
    public class MockUsers
    {
        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        //private static List<User> Users = new List<User>()
        //{
        //    new User("Hilter", "125"),
        //    new User("HitDolf", "124"),
        //    new User("TheKing", "1234"),
        //    new User("admin", "1234"),
        //    new User("mads", "1234")
        //};

        private static List<User> Users = new List<User>()
        {
            new User("admin", passwordHasher.HashPassword(null, "secret")),
            new User("mads", passwordHasher.HashPassword(null, "1234")),
            new User("chris", passwordHasher.HashPassword(null, "1234"))
        };

        public static List<User> GetAllUsers()
        {
            return Users;
        }

        public static void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}
