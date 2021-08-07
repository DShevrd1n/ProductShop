using System;
using ProductShopOOP.Abstract;


namespace ProductShopOOP.Interfaces
{
    interface IAdmin
    {
        void RemoveFromOrder();
        void CreateNewProduct(Product product);
        void DeleteProduct(Product product);

    }
}