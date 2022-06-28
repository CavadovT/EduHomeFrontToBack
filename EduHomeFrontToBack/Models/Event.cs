using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Day { get; set; }//datatime tipinden eslinde
        public string Month { get; set; }//datatime tipinden 
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public List<CategoryEvent> CategoryEvents { get; set; }

    }
}
