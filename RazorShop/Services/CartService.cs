using RazorShop.Models;

namespace RazorShop.Services
{
    public class CartService
    {
        private readonly Dictionary<int, int> _cart = new();

        public void AddToCart(int productId)
        {
            if (_cart.ContainsKey(productId))
                _cart[productId]++;
            else
                _cart[productId] = 1;
        }

        public void RemoveFromCart(int productId)
        {
            if (_cart.ContainsKey(productId))
            {
                _cart[productId]--;
                if (_cart[productId] <= 0)
                    _cart.Remove(productId);
            }
        }

        public Dictionary<int, int> GetCartItems() => _cart;
    }
}
