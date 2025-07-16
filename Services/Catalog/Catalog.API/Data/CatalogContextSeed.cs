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
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "1",
                    Name = "Wireless Mouse",
                    Category = "Electronics",
                    Summary = "Ergonomic wireless mouse",
                    Description = "High-precision wireless mouse with 1600 DPI and silent clicks.",
                    ImageFile = "mouse.png",
                    Price = 19.99M
                },
                new Product()
                {
                    Id = "2",
                    Name = "Mechanical Keyboard",
                    Category = "Electronics",
                    Summary = "RGB mechanical keyboard",
                    Description = "Mechanical keyboard with customizable RGB lighting and blue switches.",
                    ImageFile = "keyboard.png",
                    Price = 59.99M
                },
                new Product()
                {
                    Id = "3",
                    Name = "USB-C Hub",
                    Category = "Accessories",
                    Summary = "6-in-1 USB-C hub",
                    Description = "Multi-port USB-C hub with HDMI, USB 3.0, SD card reader and more.",
                    ImageFile = "hub.png",
                    Price = 29.99M
                },
                new Product()
                {
                    Id = "4",
                    Name = "Gaming Monitor",
                    Category = "Electronics",
                    Summary = "27-inch 144Hz gaming monitor",
                    Description = "Full HD 27-inch monitor with 144Hz refresh rate and 1ms response time.",
                    ImageFile = "monitor.png",
                    Price = 199.99M
                },
                new Product()
                {
                    Id = "5",
                    Name = "Bluetooth Speaker",
                    Category = "Audio",
                    Summary = "Portable Bluetooth speaker",
                    Description = "Compact speaker with 10-hour battery life and water resistance.",
                    ImageFile = "speaker.png",
                    Price = 39.99M
                },
                new Product()
                {
                    Id = "6",
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
