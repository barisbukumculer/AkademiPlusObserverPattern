using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.CompilerServices;

namespace AkademiPlusObserverPattern.DAL
{
	public class Context:IdentityDbContext<AppUser,AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-5SF4DGP\\SQLEXPRESS;initial catalog=AkademiPlusObserver;integrated security=true");
		}
		public DbSet<Discount> Discounts { get; set; }
		public DbSet<UserProcess> UserProcesses { get; set; }
		public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
	}
}
