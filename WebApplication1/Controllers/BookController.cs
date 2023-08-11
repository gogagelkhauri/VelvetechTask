using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;


[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly BookService _bookService;

    public BookController(BookService bookService)
    {
        _bookService = bookService;
    }

    // GET
    [HttpGet("/Books")]
    public async Task<IActionResult> GetBooks()
    {
        var books = await _bookService.GetBooks();
        return Ok(books);
    }
}