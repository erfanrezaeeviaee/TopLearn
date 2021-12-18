using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Toplearn.Core.Convertors;
using Toplearn.Core.DTOs;
using Toplearn.Core.Generator;
using TopLearn.Core.Security;
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

        public User LoginUser(LoginViewModel login)
        {
            string HashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string Email = FixedText.FixedEmail(login.Email);
            return _context.Users.SingleOrDefault((u => u.Email ==Email && u.Password == HashPassword));
            
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user==null || user.IsActive)
            {
                return false;
            }

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqueCode();
            _context.SaveChanges();
            return true;

        }
    }
}