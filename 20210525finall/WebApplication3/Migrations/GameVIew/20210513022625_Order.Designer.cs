﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

namespace WebApplication3.Migrations.GameVIew
{
    [DbContext(typeof(GameVIewContext))]
    [Migration("20210513022625_Order")]
    partial class Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Customer_Profile", b =>
                {
                    b.Property<int>("Customer_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Game_point")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_number");

                    b.ToTable("Customer_Profile");
                });

            modelBuilder.Entity("WebApplication3.Models.Game_mall", b =>
                {
                    b.Property<int>("Game_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Game_category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Game_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Listing_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Unit_price")
                        .HasColumnType("int");

                    b.HasKey("Game_number");

                    b.ToTable("Game_mall");
                });

            modelBuilder.Entity("WebApplication3.Models.Game_mallComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Comment_Game_number")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Game_mallsGame_number")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Game_mallsGame_number");

                    b.ToTable("Game_mallComment");
                });

            modelBuilder.Entity("WebApplication3.Models.Order", b =>
                {
                    b.Property<int>("Order_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Customer_ProfileCustomer_number")
                        .HasColumnType("int");

                    b.Property<string>("Customer_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Order_number");

                    b.HasIndex("Customer_ProfileCustomer_number");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebApplication3.Models.Orderde", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Customer_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Game_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Game_number")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Order_number")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Orderde");
                });

            modelBuilder.Entity("WebApplication3.Models.Purchase_quantitycs", b =>
                {
                    b.Property<int>("Order_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Game_mallGame_number")
                        .HasColumnType("int");

                    b.Property<int>("Game_number")
                        .HasColumnType("int");

                    b.Property<int?>("Order_number1")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Order_number");

                    b.HasIndex("Game_mallGame_number");

                    b.HasIndex("Order_number1");

                    b.ToTable("Purchase_quantitycs");
                });

            modelBuilder.Entity("WebApplication3.Models.shopping", b =>
                {
                    b.Property<int>("shoppingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Game_category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Game_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unit_price")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("shoppingId");

                    b.ToTable("shopping");
                });

            modelBuilder.Entity("WebApplication3.Models.Game_mallComment", b =>
                {
                    b.HasOne("WebApplication3.Models.Game_mall", "Game_malls")
                        .WithMany("Game_mallComments")
                        .HasForeignKey("Game_mallsGame_number");
                });

            modelBuilder.Entity("WebApplication3.Models.Order", b =>
                {
                    b.HasOne("WebApplication3.Models.Customer_Profile", "Customer_Profile")
                        .WithMany("Orders")
                        .HasForeignKey("Customer_ProfileCustomer_number");
                });

            modelBuilder.Entity("WebApplication3.Models.Purchase_quantitycs", b =>
                {
                    b.HasOne("WebApplication3.Models.Game_mall", "Game_mall")
                        .WithMany("Purchase_quantitycss")
                        .HasForeignKey("Game_mallGame_number");

                    b.HasOne("WebApplication3.Models.Order", "Order")
                        .WithMany("Purchase_quantitycss")
                        .HasForeignKey("Order_number1");
                });
#pragma warning restore 612, 618
        }
    }
}
