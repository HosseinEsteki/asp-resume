using System.ComponentModel.DataAnnotations;

namespace Resome.Models
{
    public class Property
    {
        public int Id { get; set; }
        
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 15 کاراکتر باشد")]
		[Display(Name = "عنوان شغلی")]

		public string? Title { get; set; } = "";

		[Display(Name = "شماره تلفن")]
		[MaxLength(15, ErrorMessage = "{0} نباید بیشتر از 15 کاراکتر باشد")]
		[Phone]
		[DataType(DataType.PhoneNumber)]

		public string? Phone { get; set; }

		[Display(Name = "جنسیت")]
		public string? Gender { get; set; }

		[Display(Name = "وضعیت تاهل")]
		public string? Marry { get; set; }

		[Display(Name = "تاریخ تولد")]
		public string? Birth { get; set; }

		[Display(Name = "وضعیت سربازی")]
		public string? Sarbaz { get; set; }

		[Display(Name = "شهر")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? City { get; set; }

		[Display(Name = "آدرس")]
		[MaxLength(300, ErrorMessage = "{0} نباید بیشتر از 300 کاراکتر باشد")]
		public string? Address { get; set; }
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "مقطع تحصیلی")]

		public string? Maghta1 { get; set; }
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "رشته تحصیلی")]

		public string? Reshte1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "دانشگاه/ موسسه آموزشی")]

		public string? Uni1 { get; set; }
        [MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "سال شروع")]

		public string? UniStart1 { get; set; }
		[Display(Name = "سال پایان")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? UniEnd1 { get; set; }
		[Display(Name = "مقطع تحصیلی")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Maghta2 { get; set; }
		[Display(Name = "رشته تحصیلی")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Reshte2 { get; set; }
		[Display(Name = "دانشگاه/موسسه آموزشی")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Uni2 { get; set; }
		[Display(Name = "سال شروع")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? UniStart2 { get; set; }
		[Display(Name = "سال پایان")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? UniEnd2 { get; set; }
		[Display(Name = "عنوان شغلی")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Job1 { get; set; }
		[Display(Name = "شرکت مشغول به کار")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Company1 { get; set; }
		[Display(Name = "شهر محل کار")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? City1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "سال شروع")]
        public string? JobStart1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "سال پایان")]
        public string? JobEnd1 { get; set; }
		[Display(Name = "عنوان شغلی")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Job2 { get; set; }
		[Display(Name = "شرکت مشغول به کار")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? Company2 { get; set; }
		[Display(Name = "شهر محل کار")]
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		public string? City2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "سال شروع")]
		public string? JobStart2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "سال پایان")]
		public string? JobEnd2 { get; set; }

		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "عنوان پروژه")]
        public string? Project1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "نام کارفرما")]
        public string? Karfarma1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "لینک پروژه")]
        public string? Link1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ شروع")]
        public string? ProjectStart1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ پایان")]
        public string? ProjectEnd1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "عنوان پروژه")]
        public string? Project2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "نام کارفرما")]
        public string? Karfarma2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "لینک پروژه")]
        public string? Link2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ شروع")]
        public string? ProjectStart2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ پایان")]
        public string? ProjectEnd2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "عنوان مقاله")]
        public string? Article1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "نام انتشارات")]
        public string? Nasher1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "لینک مرتبط")]
        public string? Mortabet1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ شروع")]
        public string? ArticleStart1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ پایان")]
        public string? ArticleEnd1 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "عنوان مقاله")]
        public string? Article2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "نام انتشارات")]
        public string? Nasher2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "لینک مرتبط")]
        public string? Mortabet2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ شروع")]
        public string? ArticleStart2 { get; set; }
		[MaxLength(50, ErrorMessage = "{0} نباید بیشتر از 50 کاراکتر باشد")]
		[Display(Name = "تاریخ پایان")]
        public string? ArticleEnd2 { get; set; }
		//رابطه بین دو جدول
		public int UserId { get; set; }
		public User User { get; set; }
	}
}
