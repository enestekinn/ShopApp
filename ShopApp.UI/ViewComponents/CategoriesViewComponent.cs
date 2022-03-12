using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.UI.Data;
using ShopApp.UI.Models;

namespace ShopApp.UI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "list")
            {
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            }


            return View(CategoryRepository.Categories);
        }
    }
}