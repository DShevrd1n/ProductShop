using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;


namespace ProductShopOOP.Models
{
    class Juice : Drinks
    {
        public Juice()
        {
            SubType = DrinkSubTypes.Juice;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}