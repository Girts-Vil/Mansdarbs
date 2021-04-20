using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }
        void LoadCategories();
    }
}
