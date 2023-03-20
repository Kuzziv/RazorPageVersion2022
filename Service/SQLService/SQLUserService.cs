using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Service.SQLService
{
    public class SQLUserService : IUserService
    {
        public List<User> _users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
