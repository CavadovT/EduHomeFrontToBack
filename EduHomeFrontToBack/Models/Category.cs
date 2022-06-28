using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryEvent> CategoryEvents { get; set; }
        public List<CategoryTeacher> CategoryTeachers { get; set; }


    }
}
