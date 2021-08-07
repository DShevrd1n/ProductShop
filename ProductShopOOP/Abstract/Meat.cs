using System;
using ProductShopOOP.Enums;
namespace ProductShopOOP.Abstract
{
    public abstract class Meat : Product
    {
        public Meat()
        {
            Type = ProductTypes.Meat;
        }
        internal MeatSubTypes SubType { get; set; }
    }
}