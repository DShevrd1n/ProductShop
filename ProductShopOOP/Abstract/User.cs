using System;
using ProductShopOOP.Enums;



namespace ProductShopOOP.Abstract
{
    abstract class User 
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public Roles Role { get; set; }
        

    }
}