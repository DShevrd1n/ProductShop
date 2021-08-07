using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;

namespace ProductShopOOP.Models
{
    class Cookie : Sweets
    {
        public Cookie()
        {
            SubType = SweetSubTypes.Cookie;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}