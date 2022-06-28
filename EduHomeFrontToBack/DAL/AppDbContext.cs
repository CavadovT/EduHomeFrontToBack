using EduHomeFrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHomeFrontToBack.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Biografy> Biografiys { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryEvent> CategoryEvents { get; set; }
        public DbSet<CategoryTeacher> CategoryTeachers { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<FacultyTeacher> FacultyTeachers { get; set; }
        public DbSet<Hobbi> Hobbis { get; set; }
        public DbSet<HobbiTeacher> HobbiTeachers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<RigthBoard> RigthBoards { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TestimonialArea> TestimonialAreas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VideoTour> VideoTours { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseUser> CourseUsers { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
