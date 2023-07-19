using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Resome.Context;
using Resome.Models.ViewModels;

namespace Resome.Pages.Auth
{
	public class LoginModel : PageModel
    {
		private ResomeDbContext _context=new ResomeDbContext();

		
		[BindProperty]	//مقادیر فیلد لاگین را نگه میداردSystem.InvalidOperationException: 'Sequence contains more than one element'

		public LoginViewModel Login { get; set; }
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)//اگر اطلاعات را کامل و درست وارد نکرده بود
			{
				return Page();//به صفحه ورود برگرد
			}
			// کاربری با مشخصات وارد شده را از از پایگاه داده پیدا کن
			var user = _context.Users
				.FirstOrDefault(u => u.Email == Login.Email.ToLower() && u.Password == Login.Password);
			
			if (user == null)// اگر چیزی پیدا نکردی
			{
				ModelState.AddModelError("Login.Email", "اطلاعات صحیح نمی باشد");//این  ارور را نمایش بده
				return Page();//و به همان صفحه برگرد
			}
			//وگرنه اطلاعات هویتی را بساز
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
				new Claim("Id", user.Id.ToString()),
				new Claim(ClaimTypes.Email, user.Email),
				new Claim(ClaimTypes.Name, user.Id.ToString()),


			};
			var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

			var principal = new ClaimsPrincipal(identity);

			var properties = new AuthenticationProperties
			{
				// تیک مرا به خاطر بسپار
				IsPersistent = Login.RememberMe
			};
			// با اطلاعات وارد شده ورود کن و کوکی رو بساز
			HttpContext.SignInAsync(principal, properties);

			return Redirect("/");//به صفحه ی اصلی سایت برو
		}
    }
}
