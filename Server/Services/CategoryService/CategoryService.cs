using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>{
                new Category { Id=1, Name="German made cars", Url="german cars", Icon="book"},
                new Category { Id=2, Name="Britain made cars", Url="england cars", Icon="car"},
                new Category { Id=3, Name="American made cars", Url="american cars", Icon="car"}
            };

        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}
