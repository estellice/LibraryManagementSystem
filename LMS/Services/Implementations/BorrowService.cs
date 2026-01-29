using LMS.Data;
using LMS.Models;

public class BorrowService : IBorrowService
{
    private readonly LibraryDbContext _context;

    public BorrowService(LibraryDbContext context)
    {
        _context = context;
    }

    public void BorrowBook(int bookId, int memberId)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == bookId);
        if (book == null || !book.IsAvailable)
            throw new Exception("Book not available");

        book.IsAvailable = false;

        var borrow = new Borrow
        {
            BookId = bookId,
            MemberId = memberId,
            BorrowDate = DateTime.UtcNow
        };

        _context.Loans.Add(borrow);
        _context.SaveChanges();
    }

    public void ReturnBook(int borowId)
    {
        var loan = _context.Loans.FirstOrDefault(l => l.Id == borowId);
        if (loan == null)
            throw new Exception("Loan record not found");

        loan.ReturnDate = DateTime.UtcNow;

        var book = _context.Books.FirstOrDefault(b => b.Id == loan.BookId);
        if (book != null)
            book.IsAvailable = true;

        _context.SaveChanges();
    }
}