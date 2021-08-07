using System;
using ProductShopOOP.Interfaces;
using ProductShopOOP.Abstract;
using ProductShopOOP.Enums;

namespace ProductShopOOP.Models
{
    class Courier : User, ICourier
    {
        public Courier()
        {
            Role = Roles.Courier;
        }
        public void TakeOrder(Client client, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
