using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;
using Resome.Models.ViewModels;

namespace Resome.Pages.Auth
{
	public class RegisterModel : PageModel
	{
		[BindProperty]// بعد از رفتن به ویو اطلاعات رو نگه دار
		public RegisterViewModel Register { get; set; }
		//زمانی که اطلاعات با پروتکل پست به دستت رسیدن
		public IActionResult OnPost()
		{

			if (!ModelState.IsValid)//اگر اطلاعات مشکلی داشتن
			{
				return Page();//برو همون جایی که ازش اومدی
			}
			// کلاس دیتابیس رو بساز
			ResomeDbContext _context= new ResomeDbContext();
			//اگه هر یوزری با ایمیل دریافتی وجود داشت
			if (_context.Users.Any(u => u.Email == Register.Email))
			{
				ModelState.AddModelError("Register.Email", "ایمیل وارد شده تکراری میباشد");
				return Page();
			}
			User user = new User
			{
				//فرمت ایمیل رو کوچک کن
				Email = Register.Email.ToLower(),//فرمت ایمیل رو کوچک کن
				Password = Register.Password,
				IsAdmin = false
			};

			_context.Add(user);//یوزر را به پایگاه داده اضافه کن
			_context.SaveChanges();//تغییرات را ذخیره کن
			Property property = new Property() { UserId = user.Id };//یک فیلد مشخصات کاربر اضافه کن
			_context.Add(property);
			_context.SaveChanges();
			return Redirect("/Login");
		}
	}
}
