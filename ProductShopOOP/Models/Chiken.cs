using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;

namespace ProductShopOOP.Models
{
    class Chiken : Meat
    {
        public Chiken()
        {
            SubType = MeatSubTypes.Chiken;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}   