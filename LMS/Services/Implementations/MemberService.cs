using LMS.Data;
using LMS.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

public class MemberService : IMemberService
{
    private readonly LibraryDbContext _context;

    public MemberService(LibraryDbContext context)
    {
        _context = context;
    }

    public Member AddMember(Member member)
    {
        member.CreatedAt = DateTime.UtcNow;
        member.UpdatedAt = null;
        member.LastLogin = DateTime.UtcNow; 
        member.IsActive = true;
        member.IsDeleted = false;

        _context.Members.Add(member);
        _context.SaveChanges();
        return member;
    }

    public Member UpdateMember(int id, Member updated)
    {
        var member = _context.Members.FirstOrDefault(m => m.Id == id);
        if (member == null) return null;

        member.Name = updated.Name;
        member.Email = updated.Email;
        member.IsActive = updated.IsActive;
        member.UpdatedAt = DateTime.UtcNow;
        
        _context.Members.Update(member);
        _context.SaveChanges();
        return member;
    }

    public void DeleteMember(int id)
    {
        var member = _context.Members.FirstOrDefault(m => m.Id == id);
        if (member == null) return;

        member.IsDeleted = true;
        member.IsActive = false;
        member.UpdatedAt = DateTime.UtcNow;

        _context.SaveChanges();
    }

}