using Microsoft.AspNetCore.Mvc;
using Resome.Context;
using Resome.Models;

namespace Resome.Components
{
    // این یک کامپوننت برای منوی بالای صفحه است
    //آدرس ویو در زیر نوشته شده
    // Pages.Shared.Components.TopMenu.Default
    [ViewComponent]
    public class TopMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
			ResomeDbContext _context = new ResomeDbContext();
			User user;
            if (User.Identity.IsAuthenticated)
            {
                int id = int.Parse(User.Identity.Name);
                user = _context.Users.Find(id);
            }
            else { user = new User(); }

            return View(user);
        }
    }
}
