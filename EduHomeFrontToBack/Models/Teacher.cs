using System.Collections.Generic;

namespace EduHomeFrontToBack.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int SocialAccountId { get; set; }
        public SocialAccount SocialAccount { get; set; }
        public string ImgUrl { get; set; }
        //  public string Profession { get; set; }//eslinde buda bir model olmalidi mence 
        //ve teachermodeli ile one to many elaqede olmalidi
        //yeni bir muellimin bir profesiyasi ola biler amma bir profesiyada bir nece muellim ola biler
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
        //public string Email { get; set; }
        //public decimal PhoneNumber { get; set; }
        //public string Skype { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public string Degre { get; set; }
        public string Experience { get; set; }
        public List<HobbiTeacher> HobbiTeachers { get; set; }
        public List<FacultyTeacher> FacultyTeachers { get; set; }
        public List<CategoryTeacher> CategoryTeachers { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
