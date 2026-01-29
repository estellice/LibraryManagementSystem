using LMS.Models;


public interface IBookService
{
    IEnumerable<Book> GetAllBooks();
    Book AddBook(Book book);
}
