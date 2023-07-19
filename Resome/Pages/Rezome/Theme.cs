using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages.Rezome
{
    public class ThemeModel : PageModel
    {
        ResomeDbContext _context;
        public ThemeModel(ResomeDbContext context)
        {
            _context = context;
        }
        public Property Property { get; set; }
        public User user { get; set; }
        public void OnGet()
        {
            int id = 1;
            //int id=int.Parse(User.Identity.Name);
            user = _context.Users.Find(id);
            Property = _context.Properties.SingleOrDefault(x => x.UserId == id);
        }
    }
}
