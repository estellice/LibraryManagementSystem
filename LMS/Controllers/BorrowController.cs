using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BorrowController : ControllerBase
{
    private readonly IBorrowService _borrowService;

    public BorrowController(IBorrowService borrowService)
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
    public IActionResult Return(int borrowId)
    {
        _borrowService.ReturnBook(borrowId);
        return Ok("Book returned successfully.");
    }
}
