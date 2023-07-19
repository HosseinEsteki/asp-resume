using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages.Admin.Users
{
	public class AdminAccessModel : PageModel
	{
		private readonly Resome.Context.ResomeDbContext _context;

		public AdminAccessModel(Resome.Context.ResomeDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public User User { get; set; }
		//نمایش صفحه 
		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Users == null)
			{
				return NotFound();
			}

			var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

			if (user == null)
			{
				return NotFound();
			}
			else
			{
				User = user;
			}
			return Page();
		}
		//اعطا یا حذف دسترسی ادمین
		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null || _context.Users == null)
			{
				return NotFound();
			}
			var user = await _context.Users.FindAsync(id);


			if (user != null)
			{
				if (user.IsAdmin)
				{
					user.IsAdmin = false;
				}
				else
				{
					user.IsAdmin = true;
				}

				User = user;
				_context.Attach(User).State = EntityState.Modified;
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("./Index");
		}
	}
}
