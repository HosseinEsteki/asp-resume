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
    public class IndexModel : PageModel
    {
        private readonly Resome.Context.ResomeDbContext _context;

        public IndexModel(Resome.Context.ResomeDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;
        //نمایش آنی پست ها
        public async Task OnGetAsync()
        {
            if (_context.Posts != null)
            {
                Post = await _context.Posts.ToListAsync();
            }
        }
    }
}
