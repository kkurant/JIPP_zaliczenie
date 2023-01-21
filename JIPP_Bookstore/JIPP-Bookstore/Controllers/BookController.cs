using JIPP_Bookstore.Logic;
using JIPP_Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace JIPP_Bookstore.Controllers
{
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager();
        public IActionResult Index()
        {
            var books = bookManager.GetBooks();
            
            BookModel bookModel = new BookModel();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookModel book)
        {
            bookManager.AddBook(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var book = bookManager.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            bookManager.RemoveBook(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = bookManager.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(BookModel book)
        {
            bookManager.UpdateBook(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = bookManager.GetBook(id);
            return View(book);
        }
    }
}
