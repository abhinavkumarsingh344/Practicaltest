using PracticalTest.Models;
using PracticalTest.Repository;
using System.Collections.Generic;

namespace PracticalTest.Service
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        //Constructor DI
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AddUser(User user)
        {
            var userExistStatus = _userRepository.GetUserByName(user.Name);
            if (userExistStatus == null)
            {
                _userRepository.AddUser(user);
            }
            return false;
        }


        public bool Delete(int id)
        {
            var UserExists = _userRepository.GetUserById(id);
            if (UserExists != null)
            {
                return _userRepository.Delete(id);
            }
            else
            {
                return false;
            }
        }

        public User Details(int id)
        {
            return _userRepository.Details(id);
        }


        public void Edit(User user)
        {
            var userExistStatus = _userRepository.GetUserByName(user.Name);
            if (userExistStatus == null)
            {
                _userRepository.Edit(user);
            }
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }


        public object GetUserById(int id)
        {

            return _userRepository.GetUserById(id);
        }

    }
}

