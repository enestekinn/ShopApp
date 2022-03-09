using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.UI.Models;
using ShopApp.UI.ViewModels;

namespace ShopApp.UI.Controllers
{
    public class ProductController: Controller
    {
        public IActionResult list()
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
        public IActionResult Details()
        {
            var product = new Product();
            product.Name = "samsung s6";
            product.Price = 3000;
            product.Description = "iyi telefon";
            ViewData["Category"] = "Telefonlar";
            ViewData["Product"] = product;
            return View();
        }
        
    }
}