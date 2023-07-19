using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages.Rezome
{
	public class ProfileModel : PageModel
	{
		private readonly Resome.Context.ResomeDbContext _context;

		public ProfileModel(Resome.Context.ResomeDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Property Property { get; set; } = default!;
		public User user { get; set; } = default!;
		[BindProperty]
		public IFormFile Image { get; set; }


		public async Task<IActionResult> OnGetAsync()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return Redirect("~/Login");
			}
			if (!User.Identity.IsAuthenticated)
			{
				return Redirect("~/");
			}
			int id = int.Parse(User.Identity.Name);


			if (id == null || _context.Properties == null)
			{
				return NotFound();
			}

			var property = await _context.Properties.FirstOrDefaultAsync(m => m.UserId == id);
			var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

			if (property == null)
			{
				return NotFound();
			}
			Property = property;
			this.user = user;
			return Page();
		}
		//ویرایش اطلاعات 
		public async Task<IActionResult> OnPostAsync()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return Redirect("~/");
			}
			_context.Attach(Property);
			if (user == null)
			{
				user = _context.Users.Find(Property.UserId);
			}
			if (Image?.Length > 0)
			{
				user.Image = Image.FileName;
				_context.Attach(user);
				string filePath = Path.Combine(Directory.GetCurrentDirectory(),
					"wwwroot",
					"image",
					"users",
					Image.FileName);
				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					Image.CopyTo(stream);
				}
			}
			_context.Attach(user);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PropertyExists(Property.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return RedirectToPage("~/");
		}

		private bool PropertyExists(int id)
		{
			return _context.Properties.Any(e => e.Id == id);
		}
	}
}
