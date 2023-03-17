using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        public List<User> Users { get; set; }


    }
}
