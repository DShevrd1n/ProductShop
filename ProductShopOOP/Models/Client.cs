using System;
using ProductShopOOP.Abstract;
using ProductShopOOP.Enums;
using ProductShopOOP.Interfaces;
namespace ProductShopOOP.Models
{
    class Client : User, IClient
    {
        public Client()
        {
            Role = Roles.Client;
        }
        public  void AddToBasket(Product product)
        {
            throw new NotImplementedException();
        }
        public  void FinishOrder()
        {
            throw new NotImplementedException();
        }
    }
}