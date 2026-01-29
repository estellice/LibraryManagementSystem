using LMS.Models;


public interface IMemberService
{
    Member AddMember(Member member);
    Member UpdateMember(int id, Member member); 
    void DeleteMember(int id);
}
