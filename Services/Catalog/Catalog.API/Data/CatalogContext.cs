using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext()
        {
            var client = new MongoClient("mongodb://catalogdb:27017");
            var database = client.GetDatabase("CatalogDB");

            Products = database.GetCollection<Product>("Products");
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products {  get; }
    }
}
