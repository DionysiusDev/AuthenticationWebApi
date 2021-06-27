using Authentication_WebApi.Models;
using Authentication_WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_WebApi.Services
{
    public interface IUserService
    {
        bool IsValidUserName(string userName);
        bool IsValidPassword(string password);
        string HashPassword(string password);
        string GenerateSalt();

        User CreateUser(CreateUserViewModel model);
    }
}
