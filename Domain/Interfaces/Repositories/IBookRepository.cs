using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IBookRepository
{
    Task<List<Book>> GetBooks();
    Task<Book> GetBook(int id);
    void DeleteBook(int id);
    void UpdateBook(int id, Book book);
    void Create(Book book);
}