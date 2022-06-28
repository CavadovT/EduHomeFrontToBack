namespace EduHomeFrontToBack.Models
{
    public class Biografy
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Author { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int SocialAccountId { get; set; }
        public SocialAccount SocialAccount { get; set; }


    }
}
