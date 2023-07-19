using System.ComponentModel.DataAnnotations;

namespace Resome.Models.ViewModels
{
    //جدول ثبت نام مناسب نمایش به کاربر
    public class RegisterViewModel
    {
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} الزامی است")]

        public string Password { get; set; }

        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        [Required(ErrorMessage = "{0} الزامی است")]

        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare("Password",ErrorMessage ="{0} و {1} با هم همخوانی ندارند")]
        public string RePassword { get; set; }



    }
	//جدول ورود مناسب نمایش به کاربر

	public class LoginViewModel
    {
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Password { get; set; }


        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }

    }
}
