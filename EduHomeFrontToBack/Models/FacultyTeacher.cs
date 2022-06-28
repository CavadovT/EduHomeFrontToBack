namespace EduHomeFrontToBack.Models
{
    public class FacultyTeacher
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public int TeacherId { get; set; }
        public Faculty Faculty { get; set; }
        public Teacher Teacher { get; set; }
    }
}
