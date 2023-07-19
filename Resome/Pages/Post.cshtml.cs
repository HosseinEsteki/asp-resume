using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages
{
    
    public class PostModel : PageModel
    {
		private ResomeDbContext _context;
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
        public User User { get; set; }
        public PostModel(ResomeDbContext context)
        {
            _context= context;
        }
		public void OnGet(int id)
        {
            Post= _context.Posts.Find(id);
            Posts= _context.Posts.OrderByDescending(x=>x).ToList();
            User = _context.Users.Find(Post.UserId);
        }
    }
}
