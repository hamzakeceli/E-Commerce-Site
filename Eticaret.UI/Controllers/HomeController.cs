using Eticaret.UI.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.UI.Controllers
{
    public class HomeController : Controller
    {


        private readonly CategoryServices categoryServices;
        private readonly ProductServices productServices;


        public HomeController()
        {
            categoryServices = new CategoryServices();
            productServices = new ProductServices();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductList()
        {

            var categories = categoryServices.GetCategories();
            var products = productServices.GetProducts();

            var productListViewModel = new ProductListViewModel
            {
                Categories = categories,
                Products=products,
            };

;            return View(productListViewModel);
        }
        public ActionResult ProductDetail()
        {
            return View();
        }

    }
}