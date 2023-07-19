using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resome.Context;
using Resome.Models;
using Resome.Models.ViewModels;
using System.Security.Claims;

namespace Resome.Pages.Admin.Posts
{
    //[Authorize]
    public class CreateModel : PageModel
    {

        [BindProperty]
        public AddEditPostViewModel Post { get; set; }
        ResomeDbContext _context;
        public CreateModel(ResomeDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            int id = int.Parse(User.FindFirstValue("Id"));// آیدی کاربر جاری را پیدا کن
            User Author=_context.Users.Find(id);
            Models.Post post = new Post();
            post.Description = Post.Description;
            post.User = Author;
            post.UserId= id;
            post.Image =Post.Image.FileName;
            post.ShortDiscription = Post.ShortDiscription;
            post.Title = Post.Title;
            post.Updated_At= DateTime.Now;
            _context.Add(post);//پست را به جدول اضافه کن
            _context.SaveChanges();
            //اگر عکسی آپلود کرده بود
            if (Post.Image?.Length > 0)
            {
                //عکس را ذخیره کن
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
            
            return RedirectToPage("./Index");

        }
    }
}
