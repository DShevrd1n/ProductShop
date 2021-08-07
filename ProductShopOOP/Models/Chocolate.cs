using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Abstract;


namespace ProductShopOOP.Models
{
    class Chocolate : Sweets
    {
        public Chocolate()
        {
            SubType = SweetSubTypes.Chocolate;
        }
        public override bool IsSpoiled(Product product, DateTime ShelfLife)
        {
            throw new NotImplementedException();
        }
    }
}