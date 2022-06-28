using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FacultyTeacher> FacultyTeachers { get; set; }
    }
}
