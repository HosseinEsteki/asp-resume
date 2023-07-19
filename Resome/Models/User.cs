using Resome.Context;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Resome.Models
{
	public class User
	{
		public User()
		{
			Posts = new List<Post>();
        }
		public int Id { get; set; }
		[Display(Name = "دسترسی ادمین")]
		public bool IsAdmin { get; set; }=false;

		[Display(Name = "تصویر پروفایل")]
		public string? Image { get; set; } = "avatar.jpg";

		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Required(ErrorMessage = "{0} الزامی است")]
		[Display(Name = "رمز عبور")]
		public string Password { get; set; }

		[Display(Name = "آدرس ایمیل")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]

		[Required(ErrorMessage = "{0} الزامی است")]

		public string Email { get; set; }


		[Display(Name = "نام")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]

		public string? FirstName { get; set; } = "کاربر";

		[Display(Name = "نام خانوادگی")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]

		public string? LastName { get; set; }

		[Display(Name = "بایوگرافی")]
		[MaxLength(300, ErrorMessage = "{0} نباید بیشتر از 300 کاراکتر باشد")]

		public string? Biography { get; set; } 

		public Property? Property { get; set; }

		public ICollection<Post>? Posts { get; set; }
	}
}
