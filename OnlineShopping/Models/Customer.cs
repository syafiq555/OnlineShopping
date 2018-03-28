using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping.Models
{
    public class Customer
    {
        public Customer() {
            ShoppingCart = new ShoppingCart();
        }
        public Customer(string n, string p)
        {
            ShoppingCart = new ShoppingCart();
            Name = n;
            Pass = p;
        }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}