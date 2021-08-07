using System;
using ProductShopOOP.Abstract;

namespace ProductShopOOP.Interfaces
{
    interface IClient
    {
        void AddToBasket(Product product);
        void FinishOrder();
    }
}