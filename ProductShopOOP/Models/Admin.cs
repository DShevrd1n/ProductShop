using System;
using ProductShopOOP.Abstract;
using ProductShopOOP.Enums;
using ProductShopOOP.Interfaces;

namespace ProductShopOOP.Models
{
    class Admin : User, IAdmin, IClient
    {
        public Admin()
        {
            Role = Roles.Admin;
        }
        public  void AddToBasket(Product product)
        {
            throw new NotImplementedException();
        }

        public void CreateNewProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public  void FinishOrder()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromOrder()
        {
            throw new NotImplementedException();
        }
    }
}   