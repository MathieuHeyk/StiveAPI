﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StiveAPI.Helpers;

#nullable disable

namespace StiveAPI.Migrations
{
    [DbContext(typeof(StiveController))]
    partial class StiveControllerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StiveAPI.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<int>("ID_famille")
                        .HasColumnType("int");

                    b.Property<int>("ID_fournisseur")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Prix_carton")
                        .HasColumnType("double");

                    b.Property<double>("Prix_unitaire")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("StiveAPI.Models.Commande", b =>
                {
                    b.Property<int>("Num_commande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_utilisateur")
                        .HasColumnType("int");

                    b.Property<double>("Prix_Total")
                        .HasColumnType("double");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Num_commande");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("StiveAPI.Models.Famille", b =>
                {
                    b.Property<int>("Id_famille")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_famille");

                    b.ToTable("Familles");
                });

            modelBuilder.Entity("StiveAPI.Models.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_lieu")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("StiveAPI.Models.Inventaire", b =>
                {
                    b.Property<int>("Id_inventaire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_article")
                        .HasColumnType("int");

                    b.Property<int>("Id_utilisateur")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id_inventaire");

                    b.ToTable("Inventaires");
                });

            modelBuilder.Entity("StiveAPI.Models.Lieu", b =>
                {
                    b.Property<int>("Id_lieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code_postal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_lieu");

                    b.ToTable("Lieux");
                });

            modelBuilder.Entity("StiveAPI.Models.Role", b =>
                {
                    b.Property<int>("Id_role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_role");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("StiveAPI.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id_utilisateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_lieu")
                        .HasColumnType("int");

                    b.Property<int>("Id_role")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_utilisateur");

                    b.ToTable("Utilisateurs");
                });
#pragma warning restore 612, 618
        }
    }
}
