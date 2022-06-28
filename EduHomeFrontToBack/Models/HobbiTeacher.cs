namespace EduHomeFrontToBack.Models
{
    public class HobbiTeacher
    {
        public int Id { get; set; }
        public int HobbiId { get; set; }
        public int TeacherId { get; set; }
        public Hobbi Hobbi { get; set; }
        public Teacher Teacher { get; set; }
    }
}
