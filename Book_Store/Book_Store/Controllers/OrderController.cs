using Book_Store.Data;
using Book_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Book_Store.Controllers
{
    public class OrderController : Controller
    {
        protected ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // Similar to the list method (default controller)
        public IActionResult Index()
        {
            return View();
        }

        // action add to cart (Create variables minus quantity and price in model Order)
        public IActionResult Order_Book(int id, int quantity)
        {
            Order order = new Order();
            var books = context.Books.Find(id);
            order.Book = books;
            order.BookId = id;
            order.Date = System.DateTime.Now;
            order.Customer = User.Identity.Name;
            order.Quantity = quantity;
            order.Price = books.BPrice * quantity;
            order.Image = books.BPicture;
            books.BQuantity -= quantity;
            context.Orders.Add(order);
            context.SaveChanges();

            return View(context.Orders.ToList());
        }
        //show cart
        public IActionResult List()
        {
            return View(context.Orders.ToList());
        }
        // delete book in cart
        public IActionResult Delete(int id)
        {
            var order = context.Orders.Find(id);
            context.Orders.Remove(order);
            context.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
