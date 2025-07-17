using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData (IMongoCollection<Product> productCollection)
        {
            var existProducts = productCollection.Find(p => true).Any();
            if (!existProducts)
            {
                productCollection.InsertMany(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "64df0a7bde2f3c8a14f98101",
                    Name = "Wireless Mouse",
                    Category = "Electronics",
                    Summary = "Ergonomic wireless mouse",
                    Description = "High-precision wireless mouse with 1600 DPI and silent clicks.",
                    ImageFile = "mouse.png",
                    Price = 19.99M
                },
                new Product()
                {
                    Id = "5f4e2b9a1c9d440e8c7f3a2b",
                    Name = "Mechanical Keyboard",
                    Category = "Electronics",
                    Summary = "RGB mechanical keyboard",
                    Description = "Mechanical keyboard with customizable RGB lighting and blue switches.",
                    ImageFile = "keyboard.png",
                    Price = 59.99M
                },
                new Product()
                {
                    Id = "60b7d3e4a1c2f0b23d9e4c56",
                    Name = "USB-C Hub",
                    Category = "Accessories",
                    Summary = "6-in-1 USB-C hub",
                    Description = "Multi-port USB-C hub with HDMI, USB 3.0, SD card reader and more.",
                    ImageFile = "hub.png",
                    Price = 29.99M
                },
                new Product()
                {
                    Id = "63c81a2f0b5d4e7f1a2c3d4e",
                    Name = "Gaming Monitor",
                    Category = "Electronics",
                    Summary = "27-inch 144Hz gaming monitor",
                    Description = "Full HD 27-inch monitor with 144Hz refresh rate and 1ms response time.",
                    ImageFile = "monitor.png",
                    Price = 199.99M
                },
                new Product()
                {
                    Id = "507f1f77bcf86cd799439011",
                    Name = "Bluetooth Speaker",
                    Category = "Audio",
                    Summary = "Portable Bluetooth speaker",
                    Description = "Compact speaker with 10-hour battery life and water resistance.",
                    ImageFile = "speaker.png",
                    Price = 39.99M
                },
                new Product()
                {
                    Id = "62e3a5b1f0c1234d56789abc",
                    Name = "External SSD 1TB",
                    Category = "Storage",
                    Summary = "1TB portable SSD drive",
                    Description = "High-speed USB 3.2 Gen2 external solid-state drive for fast backups.",
                    ImageFile = "ssd.png",
                    Price = 109.99M
                }
            };
        }
    }
}
