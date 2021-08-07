
using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;


namespace ProductShopOOP.Models
{
    class WhiteBread : Bread
    {
        public WhiteBread()
        {
            SubType = BreadSubTypes.White;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}