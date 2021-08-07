using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;

namespace ProductShopOOP.Models
{
    class Cow : Meat
    {
        public Cow()
        {
            SubType = MeatSubTypes.Cow;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}   