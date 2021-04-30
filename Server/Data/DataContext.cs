using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VagnersStore.Shared;

namespace VagnersStore.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "German made cars", Url = "german cars", Icon = "book" },
                new Category { Id = 2, Name = "Britain made cars", Url = "england cars", Icon = "book" },
                new Category { Id = 3, Name = "American made cars", Url = "american cars", Icon = "book" }
            );

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   CategoryId = 1,
                   Title = "Mercedes-Benz CLS55 AMG",
                   Description = "Pārdodās Merceds Benz CLS 55 AMG 2005. gada ar dzinēju V8 5.0, kuram ir 225 kW (302 HP), nobraukums sastāda 202 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/2006-Mercedes-Benz-CLS55-AMG-2.jpg/320px-2006-Mercedes-Benz-CLS55-AMG-2.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Title = "BMW 3 series G20",
                   Description = "Pārdodās BMW 3 series G20 2019. gada ar bendzīna dzinēju I6 3.0, kuram ir 185 kW (248 HP), nobraukums sastāda 100 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/8/8d/BMW_G20_IMG_0167.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 3,
                   CategoryId = 1,
                   Title = "Audi e-tron",
                   Description = "Pārdodās Audi e-tron 55 2018. gada ar elektrodzinēju, kuram ir 125 kW (168 HP), nobraukums sastāda 65 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Audi_e-tron_Sportback_Genf_2019_1Y7A5437.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 4,
                   CategoryId = 2,
                   Title = "Range Rover Sport SVR",
                   Description = "Pārdodās Range Rover Sport SVR 2018. gada ar dzinēju V8 5.0, kuram ir 431 kW (585 HP), nobraukums sastāda 165 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/8/8d/Range_Rover_Sport_SVR%2C_IAA_2017%2C_Frankfurt_%281Y7A3071%29.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 5,
                   CategoryId = 2,
                   Title = "Jaguar F-Type",
                   Description = "Pārdodās Jaguar F-Type 2019. gada ar dzinēju V8 5.0, kuram ir 431 kW (585 HP), nobraukums sastāda 162 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/6/64/Jaguar_F-Type_R%2C_TWB_18%2C_Friedrichshafen_%28OW1A0263%29.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 6,
                   CategoryId = 2,
                   Title = "Rolls-Royce Phantom",
                   Description = "Pārdodās Rolls-Royce Phantom 2020. gada ar dzinēju V12 6.75, kuram ir 420 kW (563 HP), nobraukums sastāda 35 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/a/aa/Rolls-Royce_Phantom%2C_Geneva_International_Motor_Show_2018%2C_Le_Grand-Saconnex_%281X7A1220%29.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 7,
                   CategoryId = 3,
                   Title = "Dodge Challenger SRT Demon",
                   Description = "Pārdodās Dodge Challenger SRT Demon 2020. gada ar dzinēju V8 6.2, kuram ir 712 kW (800 HP), nobraukums sastāda 95 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/7/79/Dodge_Challenger_SRT_Hellcat_2015-20180909-RM-171851.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 8,
                   CategoryId = 3,
                   Title = "Chevrolet Camaro",
                   Description = "Pārdodās Chevrolet Camaro 2017. gada ar dzinēju V8 5.4, kuram ir 485 kW (650 HP), nobraukums sastāda 102 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/f/f6/Chevrolet_Camaro_RS_%285th_gen%29%2C_2015_model%2C_Wien_26_July_2020_JM_%284%29.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               },
               new Product
               {
                   Id = 9,
                   CategoryId = 3,
                   Title = "Ford Mustang",
                   Description = "Pārdodās Ford Mustang 2019. gada ar dzinēju V8 5.0, kuram ir 380 kW (435 HP), nobraukums sastāda 115 000 km",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/f/f3/Ford_Mustang_VI_Bullit%2C_GIMS_2018%2C_Le_Grand-Saconnex_%281X7A1282%29.jpg",
                   DateCreated = new DateTime(2021, 4, 27)
               }
            );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "Ar garantiju" },
                    new Edition { Id = 3, Name = "Ar garantijas plus" },
                    new Edition { Id = 4, Name = "Bez garantijas" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
               new ProductVariant
               {
                   ProductId = 1,
                   EditionId = 2,
                   Price = 25000.00m,
                   OriginalPrice = 26.000m
               },
               new ProductVariant
               {
                   ProductId = 1,
                   EditionId = 3,
                   Price = 25300.00m
               },
               new ProductVariant
               {
                   ProductId = 1,
                   EditionId = 4,
                   Price = 24500.00m,
                   OriginalPrice = 25000.00m
               },
               new ProductVariant
               {
                   ProductId = 2,
                   EditionId = 2,
                   Price = 32500.00m,
                   OriginalPrice = 35000.00m
               },
               new ProductVariant
               {
                   ProductId = 3,
                   EditionId = 2,
                   Price = 50000.00m
               },
               new ProductVariant
               {
                   ProductId = 4,
                   EditionId = 4,
                   Price = 69000.00m,
                   OriginalPrice = 70000.00m
               },
               new ProductVariant
               {
                   ProductId = 5,
                   EditionId = 4,
                   Price = 53000.00m,
                   OriginalPrice = 55300.00m
               },
               new ProductVariant
               {
                   ProductId = 6,
                   EditionId = 4,
                   Price = 400000.00m,
                   OriginalPrice = 402000.00m
               },
               new ProductVariant
               {
                   ProductId = 7,
                   EditionId = 4,
                   Price = 72000.00m,
                   OriginalPrice = 73000.00m
               },
               new ProductVariant
               {
                   ProductId = 7,
                   EditionId = 2,
                   Price = 72300.00m
               },
               new ProductVariant
               {
                   ProductId = 7,
                   EditionId = 3,
                   Price = 72450.00m,
                   OriginalPrice = 72500.00m
               },
               new ProductVariant
               {
                   ProductId = 8,
                   EditionId = 2,
                   Price = 51000.00m,
                   OriginalPrice = 53000.00m,
               },
               new ProductVariant
               {
                   ProductId = 9,
                   EditionId = 3,
                   Price = 51300.00m
               }
           );
        }
    }
}
