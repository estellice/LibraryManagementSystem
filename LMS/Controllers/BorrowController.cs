using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LoansController : ControllerBase
{
    private readonly IBorrowService _borrowService;

    public LoansController(IBorrowService borrowService)
    {
        _borrowService = borrowService;
    }

    [HttpPost("borrow")]
    public IActionResult Borrow(int bookId, int memberId)
    {
        _borrowService.BorrowBook(bookId, memberId);
        return Ok("Book borrowed successfully.");
    }

    [HttpPost("return")]
    public IActionResult Return(int loanId)
    {
        _borrowService.ReturnBook(loanId);
        return Ok("Book returned successfully.");
    }
}
