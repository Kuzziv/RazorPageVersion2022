using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using RazorPageVersion2022.Service.JsonService;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class MockDataUserService : IUserService
    {
        public List<User> _users {  get; set; }
        private JsonFileService<User> _jsonFileService { get; set; }

        public MockDataUserService(JsonFileService<User> jsonFileService)
        {
            _jsonFileService = jsonFileService;
            //_users = MockData.MockUsers.GetAllUsers().ToList();
            _users = _jsonFileService.GetJsonItems().ToList();
        }

        public List<User> GetAllUsers()
        {
            return MockData.MockUsers.GetAllUsers();
        }

        public void AddUser(User user)
        { 
            MockData.MockUsers.AddUser(user);
            _jsonFileService.SaveJsonItems(_users);

        }
    }
}
