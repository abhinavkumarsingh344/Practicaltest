using PracticalTest.Models;
using System.Collections.Generic;

namespace PracticalTest.Service
{
    public interface IUserService
    {
        bool AddUser(User user);
        bool Delete(int id);
        User Details(int id);
        void Edit(User user);
        List<User> GetAllUsers();
        object GetUserById(int id);
    }
}
