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
    }
}
