using System;
using ProductShopOOP.Abstract;
using ProductShopOOP.Enums;

namespace ProductShopOOP.Models
{
    public abstract class Bread : Product
    {
        public Bread()
        {
            Type = ProductTypes.Bread;
        }
        internal BreadSubTypes SubType { get; set; }


    }
}