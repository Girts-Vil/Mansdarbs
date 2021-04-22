using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories()
    }
}
