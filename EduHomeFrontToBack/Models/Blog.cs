namespace EduHomeFrontToBack.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Author { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }// ve yaxud bu ucunun evezine date time tipinden creatdate or shareddate propertiesi
        public string Year { get; set; }
        public int CommitCount { get; set; }
        public string TitleIdea { get; set; }
        public string Content { get; set; }

    }
}
