using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Toplearn.Core.Convertors;
using Toplearn.Core.DTOs;
using Toplearn.Core.Services.Interfaces;

namespace Toplearn.Web.Controller
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.ISExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName","نام کاربری تکرای می باشد ");
                return View(register);
            }

            if (_userService.ISExistEmail(FixedText.FixedEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل تکرای می باشد");
                return View(register);
            }

            //ToDO: Regisetr User

            return View();
        }

    }
}
