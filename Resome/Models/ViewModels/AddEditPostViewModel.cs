using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Resome.Models.ViewModels
{
	//جدول پست ها جهت افزودن و ویرایش

	public class AddEditPostViewModel
    {
        public int Id { get; set; }
        [Display(Name = "تصویر ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public IFormFile Image { get; set; }

        [Display(Name = "عنوان ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
        public string Title { get; set; }


        [Display(Name = "توضیحات کوتاه ")]
        [MaxLength(300, ErrorMessage = "{0} نباید از 300 کاراکتر بیشتر باشد")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string ShortDiscription { get; set; }

        [Display(Name = "توضیحات ")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string Description { get; set; }




    }
}
