using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Services;

namespace RazorShop.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly CartService _cartService;
        public ProductsModel(CartService cartService) => _cartService = cartService;

        public List<RazorShop.Models.Product> Products => ProductData.Products;

        public void OnPost(int productId)
        {
            _cartService.AddToCart(productId);
        }
    }
}
