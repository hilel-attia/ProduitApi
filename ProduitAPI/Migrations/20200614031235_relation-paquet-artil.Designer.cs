﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProduitAPI.Models;

namespace ProduitAPI.Migrations
{
    [DbContext(typeof(ProduitContext))]
    [Migration("20200614031235_relation-paquet-artil")]
    partial class relationpaquetartil
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProduitAPI.Models.Article", b =>
                {
                    b.Property<Guid>("IdAR")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codeart");

                    b.Property<string>("Codetva");

                    b.Property<string>("Designation");

                    b.Property<string>("Fammile_art");

                    b.Property<double>("Pudttc");

                    b.Property<double>("Purbht");

                    b.Property<double>("Purnht");

                    b.Property<int>("Remise");

                    b.Property<int>("Taux_tva");

                    b.Property<string>("Unite");

                    b.HasKey("IdAR");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ProduitAPI.Models.Commande_frs", b =>
                {
                    b.Property<Guid>("IdCO")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datecmd");

                    b.Property<string>("Etatcmd");

                    b.Property<Guid>("IdAR");

                    b.Property<Guid>("IdFO");

                    b.Property<double>("Mntnet");

                    b.Property<double>("Mnttva");

                    b.Property<string>("Nomcmd");

                    b.HasKey("IdCO");

                    b.HasIndex("IdAR");

                    b.HasIndex("IdFO");

                    b.ToTable("Commande_frss");
                });

            modelBuilder.Entity("ProduitAPI.Models.Fournisseur", b =>
                {
                    b.Property<Guid>("IdFO")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codefrs");

                    b.Property<string>("Codetva");

                    b.Property<string>("Email");

                    b.Property<string>("Fax");

                    b.Property<string>("Pays");

                    b.Property<string>("Raiso");

                    b.Property<string>("Tel1");

                    b.Property<string>("Tel2");

                    b.Property<string>("Timbre");

                    b.Property<string>("Ville");

                    b.HasKey("IdFO");

                    b.ToTable("Fourniseurs");
                });

            modelBuilder.Entity("ProduitAPI.Models.Paquet", b =>
                {
                    b.Property<Guid>("IdPA")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodeFaq");

                    b.Property<double>("Epaisseur");

                    b.Property<Guid>("IdAR");

                    b.Property<double>("Largeur");

                    b.Property<double>("Longeur");

                    b.Property<double>("Quantite");

                    b.HasKey("IdPA");

                    b.HasIndex("IdAR");

                    b.ToTable("Paquet");
                });

            modelBuilder.Entity("ProduitAPI.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(150)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProduitAPI.Models.Commande_frs", b =>
                {
                    b.HasOne("ProduitAPI.Models.Article", "Article")
                        .WithMany("Commande_frss")
                        .HasForeignKey("IdAR")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProduitAPI.Models.Fournisseur", "Fournisseur")
                        .WithMany("Commande_frss")
                        .HasForeignKey("IdFO")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProduitAPI.Models.Paquet", b =>
                {
                    b.HasOne("ProduitAPI.Models.Article", "Article")
                        .WithMany("Paquets")
                        .HasForeignKey("IdAR")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
