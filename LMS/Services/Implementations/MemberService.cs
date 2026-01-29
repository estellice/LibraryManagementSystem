using LMS.Data;
using LMS.Models;

public class MemberService : IMemberService
{
    private readonly LibraryDbContext _context;

    public MemberService(LibraryDbContext context)
    {
        _context = context;
    }

    public Member AddMember(Member member)
    {
        _context.Members.Add(member);
        _context.SaveChanges();
        return member;
    }
}