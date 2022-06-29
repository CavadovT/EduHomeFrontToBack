using EduHomeFrontToBack.Models;
using System.Collections.Generic;

namespace EduHomeFrontToBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContent { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<RigthBoard> RigthBoards { get; set; }
        public Choose Choose { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public TestimonialArea TestimonialArea { get; set; }
        public List<Blog> Blogs { get; set; }
       
    }
}
