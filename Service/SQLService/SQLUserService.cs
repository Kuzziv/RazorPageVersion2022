using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using RazorPageVersion2022.Service.SQLQueryService;

namespace RazorPageVersion2022.Service.SQLService
{
    public class SQLUserService : IUserService
    {
        public List<User> _users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddUser(User user)
        {
            SQLQueryUser.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return SQLQueryUser.GetAllUser();
        }
    }
}
