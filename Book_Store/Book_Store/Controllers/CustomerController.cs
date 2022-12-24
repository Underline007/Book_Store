using Book_Store.Data;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ApplicationDbContext context;
        public CustomerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
