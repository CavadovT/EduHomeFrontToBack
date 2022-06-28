using System;

namespace EduHomeFrontToBack.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string CategoriyName { get; set; }
        public string Author { get; set; }
        //public DateTime SharedDate { get; set; } eslinde ucunun evezine
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

    }
}
