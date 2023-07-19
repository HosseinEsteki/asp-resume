

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Resome.Models
{
    public class Post
    {
        public Post()
        {
            User = new User();
        }
        
        public int Id { get; set; }

		[Required]
		[Display(Name = "تصویر")]
        public string Image { get; set; } = "avatar.jpg";

		[Required]
		[MaxLength(50)]
        [Display(Name ="عنوان")]

        public string Title { get; set; }

		[Required]
		[MaxLength(300)]
		[Display(Name = "توضیح کوتاه")]
		public string ShortDiscription { get; set; }

		[Required]
        [AllowHtml]
		[Display(Name = "متن")]
		public string Description { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
		[Required]
        [Display(Name ="تاریخ آخرین ویرایش")]

        public DateTime Updated_At { get; set; }


    }
}
