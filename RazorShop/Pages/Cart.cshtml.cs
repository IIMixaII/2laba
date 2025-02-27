using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Services;

namespace RazorShop.Pages
{
    public class CartModel : PageModel
    {
        private readonly CartService _cartService;
        public CartModel(CartService cartService) => _cartService = cartService;

        public Dictionary<int, int> CartItems => _cartService.GetCartItems();
        public List<RazorShop.Models.Product> Products => ProductData.Products;

        public void OnPost(int productId)
        {
            _cartService.RemoveFromCart(productId);
        }
    }
}
