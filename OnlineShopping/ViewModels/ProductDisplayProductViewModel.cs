using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShopping.Models;
namespace OnlineShopping.ViewModels
{
    public class ProductDisplayProductViewModel
    {
        public ProductDisplayProductViewModel()
        {
        }
        public ProductDisplayProductViewModel(Customer Customer, Product Product)
        {
            this.Customer = Customer;
            this.Product = Product;
        }
        public Customer  Customer { get; set; }
        public Product Product { get; set; }
    }
}