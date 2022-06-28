namespace EduHomeFrontToBack.Models
{
    public class CategoryTeacher
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TeacherId { get; set; }
        public Category Category { get; set; }
        public Teacher Teacher { get; set; }
    }
}
