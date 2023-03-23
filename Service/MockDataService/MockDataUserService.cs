using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using RazorPageVersion2022.Service.JsonService;
using RazorPageVersion2022.Service.SQLService;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class MockDataUserService : IUserService
    {
        public List<User> _users { get; set; }
        private JsonFileService<User> _jsonFileService { get; set; }
        private DbService _dbService { get; set; }

        public MockDataUserService(JsonFileService<User> jsonFileService, DbService dbService)
        {
            _dbService = dbService;
            _jsonFileService = jsonFileService;
            //_users = MockData.MockUsers.GetAllUsers().ToList();
            //_users = _jsonFileService.GetJsonObjects().ToList();
            _users = _dbService.GetUsers().Result;
        }

        public List<User> GetAllUsers()
        {
            return _users.ToList();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            _jsonFileService.SaveJsonObjects(_users);
            _dbService.SaveUsers(_users);
        }
    }
}
