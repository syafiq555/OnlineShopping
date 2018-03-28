using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;
using OnlineShopping.ViewModels;
namespace OnlineShopping.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View("RegisterCustomer");
        }

        [HttpPost]
        public ActionResult CustomerProfile(Customer c)
        {
            return View(c);
        }

        public ActionResult AddToCart(Customer c, Product p)
        {
            ProductDisplayProductViewModel cp = new ProductDisplayProductViewModel(c, p);
            cp.Customer.ShoppingCart.AddProduct(p);
            return View(cp);
        }
    }
}