using System;
using ProductShopOOP.Enums;

namespace ProductShopOOP.Models
{
    class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public PaymentType Payment { get; set; }

    }
}