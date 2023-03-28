﻿using RazorPageVersion2022.DAO;
using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        public List<User> _users { get; }

        void AddUser(User user);
        User GetUserByUserName(string userName);
        IEnumerable<OrderDAO> GetUserOrders(User user);
    }
}
