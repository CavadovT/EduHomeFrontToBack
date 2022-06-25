using EduHomeFrontToBack.DAL;
using EduHomeFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Biografiy bio = _context.Biografiys.FirstOrDefault();
            return View(await Task.FromResult(bio));

        }
    }
}
