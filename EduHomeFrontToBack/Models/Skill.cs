using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int Language { get; set; }
        public int TeamLider { get; set; }
        public int Development { get; set; }
        public int Design { get; set; }
        public int Innovation { get; set; }
        public int Communicatin { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
