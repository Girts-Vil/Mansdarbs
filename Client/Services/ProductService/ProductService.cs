﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>{
                new Product {
                    Id= 1,
                    CategoryId= 1,
                    Title ="Mercedes Benn",
                    Description= "w220 2.2. cdi utt",
                    Image= "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/2006-Mercedes-Benz-CLS55-AMG-2.jpg/320px-2006-Mercedes-Benz-CLS55-AMG-2.jpg",
                    Price= 9.999999m,
                    OriginalPrice= 19999999999999m,
                },
                new Product{
                    Id= 2,
                    CategoryId= 1,
                    Title ="BMW",
                    Description= "wpfff cdi utt",
                    Image="https://en.wikipedia.org/wiki/File:BMW_G20_IMG_0167.jpg",
                    Price= 8888889m,
                    OriginalPrice= 245842999999m,
                },
            };
        }
    }
}