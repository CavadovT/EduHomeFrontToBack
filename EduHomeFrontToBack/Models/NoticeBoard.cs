using System;

namespace EduHomeFrontToBack.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        //public DateTime CreatedTime { get; set; } stringden saxlayiram heleki
        public string CreateTime { get; set; }
        public string Content { get; set; }
    }
}
