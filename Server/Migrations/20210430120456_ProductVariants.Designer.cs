﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VagnersStore.Server.Data;

namespace VagnersStore.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210430120456_ProductVariants")]
    partial class ProductVariants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VagnersStore.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "German made cars",
                            Url = "german cars"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "book",
                            Name = "Britain made cars",
                            Url = "england cars"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "book",
                            Name = "American made cars",
                            Url = "american cars"
                        });
                });

            modelBuilder.Entity("VagnersStore.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ar garantiju"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ar garantijas plus"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bez garantijas"
                        });
                });

            modelBuilder.Entity("VagnersStore.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Merceds Benz CLS 55 AMG 2005. gada ar dzinēju V8 5.0, kuram ir 225 kW (302 HP), nobraukums sastāda 202 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/2006-Mercedes-Benz-CLS55-AMG-2.jpg/320px-2006-Mercedes-Benz-CLS55-AMG-2.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Mercedes-Benz CLS55 AMG"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās BMW 3 series G20 2019. gada ar bendzīna dzinēju I6 3.0, kuram ir 185 kW (248 HP), nobraukums sastāda 100 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/8/8d/BMW_G20_IMG_0167.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "BMW 3 series G20"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Audi e-tron 55 2018. gada ar elektrodzinēju, kuram ir 125 kW (168 HP), nobraukums sastāda 65 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Audi_e-tron_Sportback_Genf_2019_1Y7A5437.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Audi e-tron"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Range Rover Sport SVR 2018. gada ar dzinēju V8 5.0, kuram ir 431 kW (585 HP), nobraukums sastāda 165 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/8/8d/Range_Rover_Sport_SVR%2C_IAA_2017%2C_Frankfurt_%281Y7A3071%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Range Rover Sport SVR"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Jaguar F-Type 2019. gada ar dzinēju V8 5.0, kuram ir 431 kW (585 HP), nobraukums sastāda 162 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/6/64/Jaguar_F-Type_R%2C_TWB_18%2C_Friedrichshafen_%28OW1A0263%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Jaguar F-Type"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Rolls-Royce Phantom 2020. gada ar dzinēju V12 6.75, kuram ir 420 kW (563 HP), nobraukums sastāda 35 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/a/aa/Rolls-Royce_Phantom%2C_Geneva_International_Motor_Show_2018%2C_Le_Grand-Saconnex_%281X7A1220%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Rolls-Royce Phantom"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Dodge Challenger SRT Demon 2020. gada ar dzinēju V8 6.2, kuram ir 712 kW (800 HP), nobraukums sastāda 95 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/7/79/Dodge_Challenger_SRT_Hellcat_2015-20180909-RM-171851.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Dodge Challenger SRT Demon"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Chevrolet Camaro 2017. gada ar dzinēju V8 5.4, kuram ir 485 kW (650 HP), nobraukums sastāda 102 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/f/f6/Chevrolet_Camaro_RS_%285th_gen%29%2C_2015_model%2C_Wien_26_July_2020_JM_%284%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Chevrolet Camaro"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pārdodās Ford Mustang 2019. gada ar dzinēju V8 5.0, kuram ir 380 kW (435 HP), nobraukums sastāda 115 000 km",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/f/f3/Ford_Mustang_VI_Bullit%2C_GIMS_2018%2C_Le_Grand-Saconnex_%281X7A1282%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Ford Mustang"
                        });
                });

            modelBuilder.Entity("VagnersStore.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 26.000m,
                            Price = 25000.00m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 25300.00m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 25000.00m,
                            Price = 24500.00m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 35000.00m,
                            Price = 32500.00m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 50000.00m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 4,
                            OriginalPrice = 70000.00m,
                            Price = 69000.00m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 4,
                            OriginalPrice = 55300.00m,
                            Price = 53000.00m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 4,
                            OriginalPrice = 402000.00m,
                            Price = 400000.00m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 4,
                            OriginalPrice = 73000.00m,
                            Price = 72000.00m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 72300.00m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 3,
                            OriginalPrice = 72500.00m,
                            Price = 72450.00m
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 2,
                            OriginalPrice = 53000.00m,
                            Price = 51000.00m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 51300.00m
                        });
                });

            modelBuilder.Entity("VagnersStore.Shared.Product", b =>
                {
                    b.HasOne("VagnersStore.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VagnersStore.Shared.ProductVariant", b =>
                {
                    b.HasOne("VagnersStore.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VagnersStore.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("VagnersStore.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
