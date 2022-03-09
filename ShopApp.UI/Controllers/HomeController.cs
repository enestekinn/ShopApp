using Microsoft.AspNetCore.Mvc;

namespace ShopApp.UI.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        // localhost:5000/home/action
        public string Index(int id)
        {
            return "home/index/"+id;
        }
        
    }
}