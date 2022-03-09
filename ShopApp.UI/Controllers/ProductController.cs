using Microsoft.AspNetCore.Mvc;

namespace ShopApp.UI.Controllers
{
    public class ProductController: Controller
    {
        public string list()
        {
            return "product/list";
        }
        
    }
}