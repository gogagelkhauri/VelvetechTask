using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }

    public Task<Book> GetBook(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateBook(int id, Book book)
    {
        throw new NotImplementedException();
    }

    public void Create(Book book)
    {
        throw new NotImplementedException();
    }
}