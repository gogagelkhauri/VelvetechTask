using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class BookService
{
    private readonly IBookRepository _bookRepository;
    
    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<Book>> GetBooks()
    {
        return await _bookRepository.GetBooks();
    }
}