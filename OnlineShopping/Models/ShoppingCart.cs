using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping.Models
{
    public class ShoppingCart
    {
        private double totalPrice;
        private int totalProduct;
        public static int CartId { get; set; }
        public List<Product> ProductLists { get; set; }
        public ShoppingCart()
        {
            if (CartId < 1)
            {
                CartId = 0;
            }
            ProductLists = new List<Product>();
            totalProduct = 0;
            totalPrice = 0.0;
        }
        public void AddProduct(Product p)
        {
            ProductLists.Add(p);
            totalPrice += p.ProductPrice;
            totalProduct++;
        }
        public int getTotalProduct()
        {
            return totalProduct;
        }

        public double getTotalPrice()
        {
            return totalPrice;
        }
    }
}