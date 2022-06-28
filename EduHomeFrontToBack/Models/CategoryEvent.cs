namespace EduHomeFrontToBack.Models
{
    public class CategoryEvent
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int EventId { get; set; }
        public Category Category { get; set; }
        public Event Event { get; set; }
    }
}
