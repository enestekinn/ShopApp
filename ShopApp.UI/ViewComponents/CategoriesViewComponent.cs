using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.UI.Models;

namespace ShopApp.UI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category {Name = "Telefonlar", Description = "Telefonlar"},
                new Category {Name = "Bilgisayar", Description = "Bilgisayar"},
                new Category {Name = "Elektronik", Description = "Elektronik"},
            };
            return View(categories);

        }
    }
}