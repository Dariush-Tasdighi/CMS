using Microsoft.EntityFrameworkCore;

namespace Persistence
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options: options)
		{
			//Database.EnsureCreated();
		}

		public Microsoft.EntityFrameworkCore.DbSet<Domain.User> Users { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Cms.Page> Pages { get; set; }

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating
			(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly
				(assembly: typeof(Aggregates.Users.User).Assembly);
		}
	}
}
