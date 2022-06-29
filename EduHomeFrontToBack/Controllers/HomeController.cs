using EduHomeFrontToBack.DAL;
using EduHomeFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduHomeFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
       
       
        {
            HomeVM homeVm = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                SliderContent = _context.SliderContents.FirstOrDefault(),
                NoticeBoards = _context.NoticeBoards.ToList(),
                RigthBoards = _context.RigthBoards.ToList(),
                Choose=_context.Chooses.FirstOrDefault(),
                Events = _context.Events.ToList(),
                Courses=_context.Courses.Take(3).ToList(),
                TestimonialArea=_context.TestimonialAreas.FirstOrDefault(),
                Blogs=_context.Blogs.Take(3).ToList(),
            };

            return View(homeVm);
        }
    }
}
