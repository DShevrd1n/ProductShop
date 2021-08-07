using System;
using ProductShopOOP.Models;


namespace ProductShopOOP.Interfaces
{
    interface ICourier
    {
        void TakeOrder(Client client, Order order);

    }
}
