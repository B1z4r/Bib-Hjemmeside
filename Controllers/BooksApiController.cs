using Microsoft.AspNetCore.Mvc;
using Librabry_ting_ting.Data; 
using Librabry_ting_ting.Models; 
using System.Collections.Generic;
using System.Linq;


namespace Librabry_ting_ting.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksApiController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BooksApiController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _context.Books.ToList();
        }

        // POST: api/books
        [HttpPost]
        public ActionResult<Book> PostBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
        }
    }
}