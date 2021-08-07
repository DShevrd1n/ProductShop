using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;

namespace ProductShopOOP.Models
{
    class Soda : Drinks
    {
        public Soda()
        {
            SubType = DrinkSubTypes.Soda;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}