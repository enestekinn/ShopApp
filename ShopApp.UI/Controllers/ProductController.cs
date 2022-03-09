using Microsoft.AspNetCore.Mvc;

namespace ShopApp.UI.Controllers
{
    public class ProductController: Controller
    {
        public string Index()
        {
            return "product/index";
        }
        
    }
}