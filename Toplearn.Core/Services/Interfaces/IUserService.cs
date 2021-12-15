using System;
using System.Collections.Generic;
using System.Text;

namespace Toplearn.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool ISExistUserName(string UserName);
        bool ISExistEmail(string Email);

    }
}
