using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;

namespace ProductShopOOP.Models
{
    class BlackBread : Bread
    {
        public BlackBread()
        {
            SubType = BreadSubTypes.Black;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}