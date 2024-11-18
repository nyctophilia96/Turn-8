using Microsoft.EntityFrameworkCore;

namespace Turn8.Models.Classes
{
	public class Context: DbContext
	{
        public DbSet<Admin> Admins { get; set; }
		public DbSet<Address> Addresses	{ get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Comment> Comments { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data Source=YOURDATASOURCE;Initial Catalog=YOURINITIALCATALOG;Integrated Security=True;TrustServerCertificate=True");
			}
		}
	}
}
