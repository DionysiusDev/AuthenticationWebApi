using Authentication_WebApi.Models;
using Authentication_WebApi.Repositories;
using Authentication_WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_WebApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateUser(CreateUserViewModel model)
        {
            if (IsValidUserName(model.UserName))
            {
                if (IsValidPassword(model.Password))
                {
                    var user = _userRepository.CreateUser(model);

                    return user;
                }
            }

            return null;
        }

        public bool IsValidUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return false;
            }
            return true;
        }

        public string HashPassword(string password)
        {
            if (IsValidPassword(password))
            {

            }

            return null;
        }

        public string GenerateSalt()
        {
            throw new NotImplementedException();
        }

        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
    }
}
