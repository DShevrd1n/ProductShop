using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;


namespace ProductShopOOP.Models
{
    class Water : Drinks
    {
        public Water()
        {
            SubType = DrinkSubTypes.Water;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}