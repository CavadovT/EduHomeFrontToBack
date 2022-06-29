using EduHomeFrontToBack.DAL;
using EduHomeFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFrontToBack.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        
            private readonly AppDbContext _context;

            public BlogViewComponent(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IViewComponentResult> InvokeAsync(int take)
            {
                List<Blog> blogs = _context.Blogs.Take(take).ToList();
                return View(await Task.FromResult(blogs));

            }
        
    }
}
