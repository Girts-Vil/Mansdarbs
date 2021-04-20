using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>{
                new Category { Id=1, Name="German cars", Url="german cars", Icon="car"},
                new Category { Id=2, Name="England cars", Url="england cars", Icon="car"},
                new Category { Id=3, Name="American cars", Url="american cars", Icon="car"},
            };

        }
    }
}
