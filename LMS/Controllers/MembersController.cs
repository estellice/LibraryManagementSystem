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

    [HttpPut("{id}")]
    public IActionResult Update(int id, Member member)
    {
        var result = _memberService.UpdateMember(id, member);
        return Ok(result);
    }
}
