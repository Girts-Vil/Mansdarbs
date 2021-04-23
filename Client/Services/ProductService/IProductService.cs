using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Client.Services.ProductService
{
    interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl= null);
    }
}