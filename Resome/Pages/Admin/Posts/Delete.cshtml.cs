using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resome.Context;
using Resome.Models;

namespace Resome.Pages.Admin.Posts
{
    public class DeleteModel : PageModel
    {
        private readonly Resome.Context.ResomeDbContext _context;

        public DeleteModel(Resome.Context.ResomeDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Post Post { get; set; }
        //نمایش اطلاعات پست حذفی
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
            else 
            {
                Post = post;
            }
            return Page();
        }
        //حذف پست
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }
            var post = await _context.Posts.FindAsync(id);

            if (post != null)
            {
                Post = post;
				_context.Posts.Remove(Post);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
