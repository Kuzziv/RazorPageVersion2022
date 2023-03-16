using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class MockDataUserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            return MockData.MockUsers.GetAllUsers();
        }
    }
}
