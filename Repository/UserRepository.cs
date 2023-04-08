using Microsoft.EntityFrameworkCore;
using PracticalTest.Context;
using PracticalTest.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticalTest.Repository
{
    public class UserRepository : IUserRepository
    {
        UserDbContext _userDbContext;
        public UserRepository(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public bool AddUser(User user)
        {
            _userDbContext.Userss.Add(user);
            return _userDbContext.SaveChanges() == 1 ? true : false;

        }

        public bool Delete(int id)
        {
            _userDbContext.Userss.Remove(GetUserById(id));
            return _userDbContext.SaveChanges() == 1 ? false : true;

        }

        public User Details(int id)
        {
            return _userDbContext.Userss.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Edit(User user)
        {
            _userDbContext.Userss.Attach(user);
            _userDbContext.Entry(user).State = EntityState.Modified;
            _userDbContext.SaveChanges();

        }

        public List<User> GetAllUsers()
        {
            return _userDbContext.Userss.ToList();
        }

        public User GetUserById(int id)
        {
            return _userDbContext.Userss.Where(p => p.Id == id).FirstOrDefault();
        }

        public User GetUserByName(string name)
        {
            return _userDbContext.Userss.Where(p => p.Name == name).FirstOrDefault();


        }
    }
}
