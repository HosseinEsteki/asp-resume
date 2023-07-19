using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages
{
	public class AuthorModel : PageModel
	{
		public ResomeDbContext _context;
		public User Author { get; set; }
		public AuthorModel(ResomeDbContext context)
		{
			_context = context;
		}
		public void OnGet(int id)
		{
			Author = _context.Users.Find(id);
		}
	}
}
