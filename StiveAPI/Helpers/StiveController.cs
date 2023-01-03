using Microsoft.EntityFrameworkCore;
using StiveAPI.Models;

namespace StiveAPI.Helpers
{
	public class StiveController : DbContext
	{
		public DbSet<Article> Articles { get; set; }
		public DbSet<Lieu> Lieux { get; set; }
		public DbSet<Commande> Commandes { get; set; }
		public DbSet<Ligne_commande> Ligne_commandes { get; set; }
		public DbSet<Stock> Stocks { get; set; }
		public DbSet<Inventaire> Inventaires { get; set; }
		public DbSet<Utilisateur> Utilisateurs { get; set; }
		public DbSet<Fournisseur> Fournisseurs { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Famille> Familles { get; set; }

		public StiveController() { }
		public StiveController(DbContextOptions<StiveController> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//	OnModelCreatingPartial( modelBuilder );
			base.OnModelCreating(modelBuilder);
		}

		// partial void OnModelCreatingPartial( ModelBuilder modelBuilder) { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder.IsConfigured)
				return;

			optionsBuilder.UseMySql("server=localhost;user=root;database=Stive", ServerVersion.Parse("8.0.31-mysql"));
		}
	}
}
