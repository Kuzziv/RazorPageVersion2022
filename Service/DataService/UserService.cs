using RazorPageVersion2022.DAO;
using RazorPageVersion2022.EFDbContext;
using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using RazorPageVersion2022.Service.JsonService;
using RazorPageVersion2022.Service.SQLService;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class UserService : IUserService
    {
        public List<User> _users { get; }
        private JsonFileService<User> _jsonFileService;
        private DbServiceGeneric<User> _dbServiceGeneric;
        private UserDbService _userDbService;

        public UserService(JsonFileService<User> jsonFileService, DbServiceGeneric<User> dbServiceGeneric, UserDbService userDbService)
        {
            _jsonFileService = jsonFileService;
            _dbServiceGeneric = dbServiceGeneric;
            _userDbService = userDbService;
            //_users = MockData.MockUsers.GetAllUsers().ToList();
            //_users = _jsonFileService.GetJsonObjects().ToList();
            _users = _dbServiceGeneric.GetObjectsAsync().Result.ToList();            
        }

        public List<User> GetAllUsers()
        {
            return _users.ToList();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            _jsonFileService.SaveJsonObjects(_users);
            _dbServiceGeneric.AddObjectAsync(user);
        }

        public User GetUserByUserName(string userName)
        {
            return _users.Find(user => user.UserName == userName);
        }

        public User GetUserOrders(User user)
        {
            return _userDbService.GetOrdersByUserIdAsync(user.UserId).Result;
        }


    }
}
