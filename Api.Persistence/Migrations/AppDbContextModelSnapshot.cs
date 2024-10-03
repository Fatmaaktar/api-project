﻿// <auto-generated />
using System;
using Api.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 607, DateTimeKind.Local).AddTicks(7499),
                            IsDeleted = false,
                            Name = "Baby, Kids & Movies"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 607, DateTimeKind.Local).AddTicks(7537),
                            IsDeleted = false,
                            Name = "Music & Home"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 607, DateTimeKind.Local).AddTicks(7551),
                            IsDeleted = true,
                            Name = "Kids"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 608, DateTimeKind.Local).AddTicks(5823),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 608, DateTimeKind.Local).AddTicks(5826),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 608, DateTimeKind.Local).AddTicks(5829),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 608, DateTimeKind.Local).AddTicks(5832),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 616, DateTimeKind.Local).AddTicks(7845),
                            Description = "Duyulmamış kalemi ducimus voluptate çünkü.",
                            IsDeleted = false,
                            Title = "Commodi."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 616, DateTimeKind.Local).AddTicks(7922),
                            Description = "Voluptatem quia ut yaptı ratione.",
                            IsDeleted = true,
                            Title = "Vitae duyulmamış."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 616, DateTimeKind.Local).AddTicks(7982),
                            Description = "Deleniti consequatur layıkıyla incidunt reprehenderit.",
                            IsDeleted = false,
                            Title = "Yazın."
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 622, DateTimeKind.Local).AddTicks(9633),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Discount = 7.34068842671730m,
                            IsDeleted = false,
                            Price = 424.52m,
                            Title = "Small Soft Cheese"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 10, 3, 21, 44, 37, 622, DateTimeKind.Local).AddTicks(9681),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Discount = 0.1777404043328610m,
                            IsDeleted = false,
                            Price = 959.62m,
                            Title = "Gorgeous Plastic Tuna"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("Api.Domain.Entities.Detail", b =>
                {
                    b.HasOne("Api.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Api.Domain.Entities.Product", b =>
                {
                    b.HasOne("Api.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("Api.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}