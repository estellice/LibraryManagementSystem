using LMS.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }

    [HttpPost]
    public IActionResult Add(Book book)
    {
        var result = _bookService.AddBook(book);
        return Ok(result);
    }
}
