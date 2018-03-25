using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            if(CartId < 1)
            {
                CartId = 0;
            }
            ProductLists = new List<Product>();

        }
        public void AddProduct(Product p)
        {
            ProductLists.Add(p); 
        }
        public static int CartId { get; set; }
        public List <Product> ProductLists { get; set; }
    }
}