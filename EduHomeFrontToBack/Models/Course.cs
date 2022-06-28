using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string AboutCourse { get; set; }
        public string HowToApply { get; set; }
        public string Certification { get; set; }
        public string LeaveAReplay { get; set; }
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int StudentsCount { get; set; }
        public string Assesments { get; set; }
        public double CoursePrice { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
        public List<CourseUser> CourseUsers { get; set; }

    }
}
