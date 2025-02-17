using dot_net_core_ex.Data;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_core_ex.Controllers
{
    //route for controller
    [Route("api/[controller]")]
    public class BooksController:Controller
    {
        private IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }

        //Create a new book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok();
        }

        //Read all books
        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }

        //Update an existing book
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {
            _service.UpdateBook(id, book);
            return Ok(book);
        }

        //Delete book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        //Get a single book by ID
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _service.GetBookByID(id);
            return Ok(book);
        }



    }
}