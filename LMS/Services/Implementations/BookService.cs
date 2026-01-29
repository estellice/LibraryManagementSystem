using LMS.Data;
using LMS.Models;

public class BookService : IBookService
{
    private readonly LibraryDbContext _context;

    public BookService(LibraryDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _context.Books.ToList();
    }

    public Book AddBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return book;
    }
}
