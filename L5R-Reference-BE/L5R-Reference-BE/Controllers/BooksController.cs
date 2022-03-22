using L5R_Reference_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public Dictionary<int,string> Get()
        {
            return _bookService.GetBooks();
        }

        [HttpGet("{id:length(1)}")]
        public string Get(string id)
        {
            return _bookService.GetBook(int.Parse(id));
        }

    }
}
