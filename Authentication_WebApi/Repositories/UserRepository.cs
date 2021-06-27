using Authentication_WebApi.Models;
using Authentication_WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_WebApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User CreateUser(CreateUserViewModel model)
        {
            var createdUser = new User
            {
                UserName = model.UserName,
                Password = model.Password,
                Salt = "!@#$",
                RefreshTokens = null
            };
                
            _context.Users.Add(createdUser);
            _context.SaveChanges();

            return createdUser;
        }

        public void UpdateUser(User user)
        {
            var updatedUser = _context.Users.Attach(user);
            updatedUser.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public User GetUserByName(string userName)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == userName);
        }
    }
}
