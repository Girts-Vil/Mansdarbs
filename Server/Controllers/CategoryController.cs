using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vagnersstore.Shared;

namespace VagnersStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(new List<Category>{
                new Category { Id=1, Name="German made cars", Url="german cars", Icon="book"},
                new Category { Id=2, Name="Britain made cars", Url="england cars", Icon="car"},
                new Category { Id=3, Name="American made cars", Url="american cars", Icon="car"},
            });
        }
    }
}
