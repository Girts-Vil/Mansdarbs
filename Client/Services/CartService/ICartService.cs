using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VagnersStore.Shared;

namespace VagnersStore.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
    }
}
