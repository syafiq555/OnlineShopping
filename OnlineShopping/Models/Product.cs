using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping.Models
{
    public class Product
    {
        public List<Product> ProductLists { get; set; }
        public Product()
        {
            ProductLists = new List<Product>();
            for (int i = 1; i < 10; i++)
            {
                ProductLists.Add(new Product("Water Dispenser " + i, i));
            }
        }
        public Product(string ProductName, float ProductPrice)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
        }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
    }
}