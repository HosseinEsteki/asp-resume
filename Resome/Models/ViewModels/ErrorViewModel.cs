namespace Resome.Models.ViewModels
{
	//جدول ارورها مناسب نمایش به کاربر

	public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}