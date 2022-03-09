using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.UI.Models;
using ShopApp.UI.ViewModels;

namespace ShopApp.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var products = new List<Product>()
            {
                new Product {Name = "Samsung S4", Price = 2000, Description = "iyi telefon"}, 
                new Product {Name = "Samsung S5", Price = 5000, Description = "guzel"},
                new Product {Name = "Samsung S5", Price = 5000, Description = "guzel"},
                new Product {Name = "Samsung S5", Price = 5000, Description = "guzel"}
            };

    

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }
        
    }
}