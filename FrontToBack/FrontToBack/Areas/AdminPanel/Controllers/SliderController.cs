using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel") ]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders =await _context.Sliders.Where(s=> !s.IsDeleted).ToListAsync();
            return View(sliders );
        }
    }
}
