using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VagnersStore.Shared;

namespace VagnersStore.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
    }
}
