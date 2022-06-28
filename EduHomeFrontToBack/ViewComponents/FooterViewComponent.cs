using EduHomeFrontToBack.DAL;
using EduHomeFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFrontToBack.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Biografy bio = _context.Biografiys.Include(b=>b.SocialAccount).FirstOrDefault();

            return View(await Task.FromResult(bio));

        }
    }
}
