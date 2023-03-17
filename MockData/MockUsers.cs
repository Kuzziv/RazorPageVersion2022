using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.MockData
{
    public class MockUsers
    {
        private static List<User> Users = new List<User>()
        {
            new User("Hilter", "125"),
            new User("HitDolf", "124"),
            new User("TheKing", "1234"),
            new User("admin", "1234"),
            new User("mads", "1234")
        };

        public static List<User> GetAllUsers()
        {
            return Users;
        }

    }
}
