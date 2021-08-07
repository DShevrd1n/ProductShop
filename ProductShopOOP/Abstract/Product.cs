using System;
using ProductShopOOP.Enums;

namespace ProductShopOOP.Abstract
{
    public abstract class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Firm { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }
        public DateTime ShelfLife { get; set; }

        public string Image { get; set; }
        public ProductTypes Type { get; set; }
        public abstract bool IsSpoiled(Product product, DateTime ShelfLife);
    }
}