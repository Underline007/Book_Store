using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    public class StoreOwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
