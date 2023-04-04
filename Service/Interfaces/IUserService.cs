using RazorPageVersion2022.DAO;
using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        public List<User> _users { get; }

        Task AddUserAsync(User user);
        User GetUserByUserName(string userName);
        User GetUserOrders(User user);
    }
}
