using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resome.Context;
using Resome.Models;
using Resome.Models.ViewModels;

namespace Resome.Pages.Admin.Posts
{
    public class EditModel : PageModel
	{
		private readonly Resome.Context.ResomeDbContext _context;

		public EditModel(Resome.Context.ResomeDbContext context)
		{
			_context = context;
			Post = new AddEditPostViewModel();
		}

		[BindProperty]
		public AddEditPostViewModel Post { get; set; } = default!;
		[BindProperty]

		public string image { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Posts == null)
			{
				return NotFound();
			}

			var post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);
			if (post == null)
			{
				return NotFound();
			}
			Post.ShortDiscription = post.ShortDiscription;
			Post.Description = post.Description;
			Post.Title = post.Title;
			Post.Id = post.Id;
			image = post.Image;
			return Page();
		}
		public async Task<IActionResult> OnPostAsync()
		{
			int id = int.Parse(User.Identity.Name);
			User Author = _context.Users.Find(id);
			Post post = _context.Posts.Find(Post.Id);
			post.Description = Post.Description;
			post.User = Author;
			post.UserId = id;
			post.ShortDiscription = Post.ShortDiscription;
			post.Title = Post.Title;
			post.Updated_At = DateTime.Now;
			if (Post.Image?.Length > 0)
			{
				post.Image = Post.Image.FileName;
				string filePath = Path.Combine(Directory.GetCurrentDirectory(),
					"wwwroot",
					"image",
					"posts",
					Post.Image.FileName);
				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					Post.Image.CopyTo(stream);
				}
			}
			_context.Attach(post);

			try
			{
				await _context.SaveChangesAsync();

				
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PostExists(Post.Id))
				{

					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return RedirectToPage("./Index");
		}

		private bool PostExists(int id)
		{
			return _context.Posts.Any(e => e.Id == id);
		}
	}
}
