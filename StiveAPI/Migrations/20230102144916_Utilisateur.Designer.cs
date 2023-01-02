﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StiveAPI.Helpers;

#nullable disable

namespace StiveAPI.Migrations
{
    [DbContext(typeof(StiveController))]
    [Migration("20230102144916_Utilisateur")]
    partial class Utilisateur
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                    b.Property<int>("Id_Commande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int>("Id_Utilisateur")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("double");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_Commande");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("StiveAPI.Models.Inventaire", b =>
                {
                    b.Property<int>("Id_Inventaire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int>("Id_Utilisateur")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id_Inventaire");

                    b.ToTable("Inventaires");
                });

            modelBuilder.Entity("StiveAPI.Models.Lieu", b =>
                {
                    b.Property<int>("Id_Lieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Code_Postal")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Pays")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Ville")
                        .HasColumnType("int");

                    b.HasKey("Id_Lieu");

                    b.ToTable("Lieux");
                });

            modelBuilder.Entity("StiveAPI.Models.Ligne_de_commande", b =>
                {
                    b.Property<int>("Id_Ligne_de_Commande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_Article")
                        .HasColumnType("int");

                    b.Property<int>("Numero_de_Commande")
                        .HasColumnType("int");

                    b.Property<int>("quantite")
                        .HasColumnType("int");

                    b.HasKey("Id_Ligne_de_Commande");

                    b.ToTable("Ligne_des_commandes");
                });

            modelBuilder.Entity("StiveAPI.Models.Stock", b =>
                {
                    b.Property<int>("Id_Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Article")
                        .HasColumnType("int");

                    b.Property<string>("quantite")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_Stock");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("StiveAPI.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id_Utilisateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_Lieu")
                        .HasColumnType("int");

                    b.Property<string>("Id_Ròle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mot_de_Passe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom_de_Famille")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Prenome")
                        .HasColumnType("int");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("Id_Utilisateur");

                    b.ToTable("utilisateurs");
                });
#pragma warning restore 612, 618
        }
    }
}
