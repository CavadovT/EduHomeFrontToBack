namespace EduHomeFrontToBack.Models
{
    public class CourseUser
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
