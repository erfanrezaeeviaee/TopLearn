using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Toplearn.Core.Services.Interfaces;
using Toplearn.DataLayer.Context;
using Toplearn.DataLayer.Entities.User;

namespace Toplearn.Core.Services
{
    public class UserService:IUserService
    {
        private ToplearnContext _context;

        public UserService(ToplearnContext context)
        {
            _context = context;
        }

        

        public bool ISExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool ISExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }
    }
}