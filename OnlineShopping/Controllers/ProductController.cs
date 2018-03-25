using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;
using OnlineShopping.ViewModels;
namespace OnlineShopping.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayProduct(Customer C)
        {
            Product P = new Product();
            ProductDisplayProductViewModel CP = new ProductDisplayProductViewModel(C,P);
            
            return View(CP);
        }
        
    }
}