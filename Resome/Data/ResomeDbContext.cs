using Microsoft.EntityFrameworkCore;
using Resome.Models;

namespace Resome.Context
{
	public class ResomeDbContext : DbContext
	{
		public ResomeDbContext(DbContextOptions<ResomeDbContext> options) : base(options)
		{
		}
		public ResomeDbContext() : base()
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseMySQL("User id=root; password=; database=Rezome; host=127.0.0.1");
			optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Projects\\Visual Studio\\MecaApp\\DataAccess\\Data\\MyDataBase.mdf\";Integrated Security=True;Connect Timeout=30");
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Property> Properties { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}


	}
}
