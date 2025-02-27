using RazorShop.Models;

namespace RazorShop.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Ноутбук", Description = "Игровой ноутбук", Price = 1200.99m, ImageUrl = "/images/laptop.jpg" },
            new Product { Id = 2, Name = "Смартфон", Description = "Флагманский телефон", Price = 799.99m, ImageUrl = "/images/phone.jpg" },
            new Product { Id = 3, Name = "Часы", Description = "Умные часы", Price = 199.99m, ImageUrl = "/images/watch.jpg" }
        };
    }
}
