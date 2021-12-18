using System.ComponentModel.DataAnnotations;

namespace Toplearn.Core.DTOs
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(200, ErrorMessage = "{0}نمی تواند بیشتر از {1} کاراکتر باشد ")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(200, ErrorMessage = "{0}نمی تواند بیشتر از {1} کاراکتر باشد ")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(200, ErrorMessage = "{0}نمی تواند بیشتر از {1} کاراکتر باشد ")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(200, ErrorMessage = "{0}نمی تواند بیشتر از {1} کاراکتر باشد ")]
        [Compare("Password",ErrorMessage = "کلمه عبور وارد شده مغایرت دارد")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(200, ErrorMessage = "{0}نمی تواند بیشتر از {1} کاراکتر باشد ")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(200, ErrorMessage = "{0}نمی تواند بیشتر از {1} کاراکتر باشد ")]
        public string Password { get; set; }
        [Display(Name = " مرا بخاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
