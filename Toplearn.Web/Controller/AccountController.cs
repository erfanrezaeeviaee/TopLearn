using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Toplearn.Core.Convertors;
using Toplearn.Core.DTOs;
using Toplearn.Core.Generator;
using TopLearn.Core.Security;
using Toplearn.Core.Services.Interfaces;
using Toplearn.DataLayer.Entities.User;

namespace Toplearn.Web.Controller
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.ISExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری تکرای می باشد ");
                return View(register);
            }

            if (_userService.ISExistEmail(FixedText.FixedEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل تکرای می باشد");
                return View(register);
            }

            User user = new User
            {

                UserName = register.UserName,
                Email = FixedText.FixedEmail(register.Email),
                Password = PasswordHelper.EncodePasswordMd5(register.RePassword),
                ActiveCode = NameGenerator.GenerateUniqueCode(),
                IsActive = false,
                RegisterDate = DateTime.Now,
                UserAvatar = "Default.jpg",
            };
            _userService.AddUser(user);
            //TODO: Send Activation Email

            return View("SuccessRegister", user);

        }
        #endregion

        #region Login
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }


        #endregion
    }
}
