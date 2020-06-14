using ProduitAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProduitAPI.Models
{
    public class ProduitContext : IdentityDbContext
    {
        public ProduitContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Commande_frs> Commande_frss { get; set; }
        
        public DbSet<Article> Articles { get; set; }
        public DbSet<Fournisseur> Fourniseurs { get; set; }
        
        public DbSet<Paquet> Paquets { get; set; }

        public DbSet<FactureFrs> FactureFrs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            {
                //one to many article and commande_frs
                modelBuilder.Entity<Article>()
               .HasMany(p => p.Commande_frss)
               .WithOne(x => x.Article)
               .HasForeignKey(y => y.IdAR);

                //one to many fournisseur and commande_frs
                modelBuilder.Entity<Fournisseur>()
              .HasMany(p => p.Commande_frss)
              .WithOne(x => x.Fournisseur)
              .HasForeignKey(y => y.IdFO);
                //one to many article  and paquet
                modelBuilder.Entity<Article>()
              .HasMany(p => p.Paquets)
              .WithOne(x => x.Article)
              .HasForeignKey(y => y.IdAR);

                //one to one facturefrs and commande_frs
                modelBuilder.Entity<FactureFrs>()
                  .HasOne(a => a.Commande_frs)
                  .WithOne(b => b.FactureFrs)
                  .HasForeignKey<Commande_frs>(b => b.IdFac);


                //one to one facturefrs and commande_frs
                modelBuilder.Entity<FactureFrs>()
                  .HasOne(a => a.Fournisseur)
                  .WithOne(b => b.FactureFrs)
                  .HasForeignKey<Fournisseur>(b => b.IdFO);

                modelBuilder.Entity<FactureFrs>()
            .HasMany(p => p.LigneFactureFrss)
            .WithOne(x => x.FactureFrs)
            .HasForeignKey(y => y.IdFac);


            }
        }


        public DbSet<ProduitAPI.Models.LigneFactureFrs> LigneFactureFrs { get; set; }




        
    } 

}