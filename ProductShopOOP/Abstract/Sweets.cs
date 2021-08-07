using System;
using ProductShopOOP.Enums;
namespace ProductShopOOP.Abstract
{
    public abstract class Sweets : Product
    {
        public Sweets()
        {
            Type = ProductTypes.Sweets;
        }
        internal SweetSubTypes SubType { get; set; }
    }
}   