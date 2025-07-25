﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Catalog.API.Entities
{
    public class Product
    {
        [BsonRepresentation(BsonType.ObjectId)] //iako je ovde id string, u bazi ga tretiraj kao ObjectId
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }


    }
}
