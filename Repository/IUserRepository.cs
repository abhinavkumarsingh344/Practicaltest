using PracticalTest.Models;
using System.Collections.Generic;

namespace PracticalTest.Repository
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        bool Delete(int id);
        User Details(int id);
        void Edit(User user);
        List<User> GetAllUsers();
        User GetUserById(int id);
        User GetUserByName(string name);
    }
}
