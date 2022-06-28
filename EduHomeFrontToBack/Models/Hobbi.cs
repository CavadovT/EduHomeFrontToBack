using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Hobbi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<HobbiTeacher> HobbiTeachers { get; set; }
    }
}
