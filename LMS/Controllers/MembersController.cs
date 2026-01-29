using LMS.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    private readonly IMemberService _memberService;

    public MembersController(IMemberService memberService)
    {
        _memberService = memberService;
    }

    [HttpPost]
    public IActionResult Add(Member member)
    {
        var result = _memberService.AddMember(member);
        return Ok(result);
    }
}
