using LMS.Models;


public interface IBorrowService
{
    void BorrowBook(int bookId, int memberId);
    void ReturnBook(int loanId);
}
