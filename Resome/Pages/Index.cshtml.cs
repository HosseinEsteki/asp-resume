using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages
{
    public class IndexModel : PageModel
    {
		public ResomeDbContext _context { get; set; }
		public List<Post> Posts { get; set; }
		public IndexModel(ResomeDbContext context)
		{
			_context= context;
		}
        public void OnGet()
        {
			_context.Database.EnsureCreated();
			Posts = _context.Posts.ToList();
		}
    }
}
