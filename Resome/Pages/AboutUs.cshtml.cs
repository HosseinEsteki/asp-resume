using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages
{
    public class AboutUsModel : PageModel
    {
		private ResomeDbContext _context;
        public User User { get; set; }
        public List<Post> Posts { get; set; }
        public AboutUsModel(ResomeDbContext context)
        {
            _context=context;
        }
        public void OnGet(int user)
        {
            User= _context.Users.Find(user);
            Posts=_context.Posts.OrderByDescending(x=>x).ToList();
        }
    }
}
