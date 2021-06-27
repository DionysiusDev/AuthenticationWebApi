using Authentication_WebApi.Models;
using Authentication_WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_WebApi.Repositories
{
    public interface IUserRepository
    {
        User CreateUser(CreateUserViewModel user);
        void UpdateUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        User GetUserByName(string userName);
        bool IsExistingUserName(string UserName);
    }
}
