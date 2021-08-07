using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;


namespace ProductShopOOP.Models
{
    class Candies : Sweets
    {
        public Candies()
        {
            SubType = SweetSubTypes.Candies;

        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}