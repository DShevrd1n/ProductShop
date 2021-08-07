using System;
using ProductShopOOP.Enums;

namespace ProductShopOOP.Abstract
{
    public abstract class Drinks : Product
    {
        public Drinks()
        {
            Type = ProductTypes.Drinks;
        }
        internal DrinkSubTypes SubType { get; set; }
    }
}