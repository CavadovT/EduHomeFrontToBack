namespace EduHomeFrontToBack.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int SocialAccountId { get; set; }
        public SocialAccount SocialAccount { get; set; }
    }
}
