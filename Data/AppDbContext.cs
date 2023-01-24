using CameroonTradeInformationPortal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Categorie_Article> Categorie_Articles { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Loi> Lois { get; set; }
        public DbSet<Marchandise> Marchandises { get; set; }
        public DbSet<Mesure_Marchandise> Mesure_Marchandises { get; set; }
        public DbSet<Mesure> Mesures { get; set; }
        public DbSet<Mesure_Produit> mesure_Produits { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Norme> Normes { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Regime_Procedure> Regime_Procedures { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Produit_Region> Produits_Regions { get; set; }
        public DbSet<Regime> Regimes { get; set; }
        public DbSet<Regle> Regles { get; set; }
        public DbSet<Regle_Marchandise> Regles_Marchandises { get; set; }
        public DbSet<Tarif_Douanier> Tarif_Douaniers { get; set; }
        public DbSet<Langue> Langues { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Role_Compte> Roles_Comptes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie_Article>().HasKey(am => new
            {
                am.CategorieId,
                am.ArticleId
            });

            modelBuilder.Entity<Categorie_Article>().HasOne(m => m.Categorie).WithMany(am => am.Categories_Articles).HasForeignKey(m => m.CategorieId);
            modelBuilder.Entity<Categorie_Article>().HasOne(m => m.Article).WithMany(am => am.Categories_Articles).HasForeignKey(m => m.ArticleId);

            modelBuilder.Entity<Mesure_Marchandise>().HasKey(am => new
            {
                am.MesureId,
                am.MarchandiseId
            });

            modelBuilder.Entity<Mesure_Marchandise>().HasOne(m => m.Mesure).WithMany(am => am.Mesures_Marchandises).HasForeignKey(m => m.MesureId);
            modelBuilder.Entity<Mesure_Marchandise>().HasOne(m => m.Marchandise).WithMany(am => am.Mesures_Marchandises).HasForeignKey(m => m.MarchandiseId);

            modelBuilder.Entity<Mesure_Produit>().HasKey(am => new
            {
                am.MesureId,
                am.ProduitId
            });

            modelBuilder.Entity<Mesure_Produit>().HasOne(m => m.Mesure).WithMany(am => am.Mesures_Produits).HasForeignKey(m => m.MesureId);
            modelBuilder.Entity<Mesure_Produit>().HasOne(m => m.Produit).WithMany(am => am.Mesures_Produits).HasForeignKey(m => m.MesureId);

            modelBuilder.Entity<Produit_Region>().HasKey(am => new
            {
                am.ProduitId,
                am.RegionId
            });

            modelBuilder.Entity<Produit_Region>().HasOne(m => m.Produit).WithMany(am => am.Produits_Regions).HasForeignKey(m => m.ProduitId);
            modelBuilder.Entity<Produit_Region>().HasOne(m => m.Region).WithMany(am => am.Produits_Regions).HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Regime_Procedure>().HasKey(am => new
            {
                am.RegimeId,
                am.ProcedureId
            });

            modelBuilder.Entity<Regime_Procedure>().HasOne(m => m.Regime).WithMany(am => am.Regimes_Procedures).HasForeignKey(m => m.RegimeId);
            modelBuilder.Entity<Regime_Procedure>().HasOne(m => m.Procedure).WithMany(am => am.Regimes_Procedures).HasForeignKey(m => m.ProcedureId);

            modelBuilder.Entity<Regle_Marchandise>().HasKey(am => new
            {
                am.RegleId,
                am.MarchandiseId
            });

            modelBuilder.Entity<Regle_Marchandise>().HasOne(m => m.Marchandise).WithMany(am => am.Regles_Marchandises).HasForeignKey(m => m.MarchandiseId);
            modelBuilder.Entity<Regle_Marchandise>().HasOne(m => m.Regle).WithMany(am => am.Regles_Marchandises).HasForeignKey(m => m.RegleId);

            modelBuilder.Entity<Role_Compte>().HasKey(am => new
            {
                am.RoleId,
                am.CompteId
            });

            modelBuilder.Entity<Role_Compte>().HasOne(m => m.Role).WithMany(am => am.Roles_Comptes).HasForeignKey(m => m.RoleId);
            modelBuilder.Entity<Role_Compte>().HasOne(m => m.Compte).WithMany(am => am.Roles_Comptes).HasForeignKey(m => m.CompteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
