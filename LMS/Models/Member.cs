namespace LMS.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get;set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
