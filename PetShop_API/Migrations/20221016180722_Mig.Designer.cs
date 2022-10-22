﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop_API.Models;

#nullable disable

namespace PetShop_API.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20221016180722_Mig")]
    partial class Mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetShop_API.Models.CatFeedModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductsModelId")
                        .HasColumnType("int");

                    b.Property<string>("Transcrypt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductsModelId");

                    b.ToTable("CatProducts");
                });

            modelBuilder.Entity("PetShop_API.Models.DogFeedModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductsModelId")
                        .HasColumnType("int");

                    b.Property<string>("Transcrypt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductsModelId");

                    b.ToTable("DogProducts");
                });

            modelBuilder.Entity("PetShop_API.Models.FishFeedModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductsModelId")
                        .HasColumnType("int");

                    b.Property<string>("Transcrypt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductsModelId");

                    b.ToTable("FishProducts");
                });

            modelBuilder.Entity("PetShop_API.Models.ParrotFeedModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductsModelId")
                        .HasColumnType("int");

                    b.Property<string>("Transcrypt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductsModelId");

                    b.ToTable("ParrotProducts");
                });

            modelBuilder.Entity("PetShop_API.Models.ProductsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PetShop_API.Models.CatFeedModel", b =>
                {
                    b.HasOne("PetShop_API.Models.ProductsModel", null)
                        .WithMany("CatsFeeds")
                        .HasForeignKey("ProductsModelId");
                });

            modelBuilder.Entity("PetShop_API.Models.DogFeedModel", b =>
                {
                    b.HasOne("PetShop_API.Models.ProductsModel", null)
                        .WithMany("DogtsFeeds")
                        .HasForeignKey("ProductsModelId");
                });

            modelBuilder.Entity("PetShop_API.Models.FishFeedModel", b =>
                {
                    b.HasOne("PetShop_API.Models.ProductsModel", null)
                        .WithMany("FishFeeds")
                        .HasForeignKey("ProductsModelId");
                });

            modelBuilder.Entity("PetShop_API.Models.ParrotFeedModel", b =>
                {
                    b.HasOne("PetShop_API.Models.ProductsModel", null)
                        .WithMany("ParrotsFeeds")
                        .HasForeignKey("ProductsModelId");
                });

            modelBuilder.Entity("PetShop_API.Models.ProductsModel", b =>
                {
                    b.Navigation("CatsFeeds");

                    b.Navigation("DogtsFeeds");

                    b.Navigation("FishFeeds");

                    b.Navigation("ParrotsFeeds");
                });
#pragma warning restore 612, 618
        }
    }
}
