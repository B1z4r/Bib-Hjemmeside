using Microsoft.AspNetCore.Mvc;
using Librabry_ting_ting.Data; 
using System.Linq;

using Librabry_ting_ting.Models;

namespace Librabry_ting_ting.Controllers 
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _context;

        public BooksController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Books
        public IActionResult Index()
        {
            var books = _context.Books.ToList(); // Hent alle bøger fra databasen
            return View(books);
        }

        // POST: Books/Create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book); // Tilføj bogen til databasen
                _context.SaveChanges(); // Gem ændringerne
                return RedirectToAction(nameof(Index)); // Kald metoden korrekt
            }
            return View(book); // Returner til visningen med fejl
        }
    }
}