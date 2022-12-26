using Book_Store.Data;
using Book_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Book_Store.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //list book by all
        public IActionResult Index()
        {
            return View(context.Books.ToList());
        }
        // book detail by all
        public IActionResult Detail(int id)
        {
            var book = context.Books.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            return View(book);
        }

        // search by all
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var books = context.Books.Where(p => p.BName.Contains(keyword)).ToList();
            if (books.Count == 0)
            {
                TempData["Message"] = "No Product Found !";
            } else
            {
                TempData["Message"] = "Found" + books.Count + "Result";
            }
            return View("Index", books);
        }
        //help page
        public IActionResult Help()
        {
            return View();
        }

        //Show list by store owner
        public IActionResult StoreOwner()
        {
            var categories = context.Categories.ToList();
            return View(context.Books.ToList());
        }
        //delete book by store owner
        public IActionResult Delete(int? id)
        {
            var book = context.Books.Find(id);
            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("StoreOwner");
        }
        [HttpGet]
        public IActionResult Add()
        {
                var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }
        //add book by store owner
        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("StoreOwner");
            }
            else
            {
                ViewBag.Categories = context.Categories.ToList();
                return View(book);
            }

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(context.Books.Find(id));
        }

        //edit book by store owner
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("StoreOwner");
            }
            else
            {
                ViewBag.Categories = context.Categories.ToList();
                return View(book);
            }
        }
    }
}
