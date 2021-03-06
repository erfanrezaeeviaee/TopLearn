using System;
using System.Collections.Generic;
using System.Text;
using Toplearn.Core.DTOs;
using Toplearn.DataLayer.Entities.User;

namespace Toplearn.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool ISExistUserName(string UserName);
        bool ISExistEmail(string Email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        bool ActiveAccount(string activeCode);

    }
}
