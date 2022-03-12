using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.UI.Data;
using ShopApp.UI.Models;
using ShopApp.UI.ViewModels;

namespace ShopApp.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }
    }
}