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
    public class IndexModel : PageModel
    {
        private readonly Resome.Context.ResomeDbContext _context;

        public IndexModel(Resome.Context.ResomeDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }

    }
}
