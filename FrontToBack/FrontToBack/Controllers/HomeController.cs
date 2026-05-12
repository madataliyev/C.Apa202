
using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.Services;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;


        public HomeController(AppDbContext context ,IEmailService emailService )
        {
           _context = context;
            _emailService = emailService;
        }

        public async Task<IActionResult> Index()
        {
            _emailService.SendEmail();

     

            List<Slider> sliders =await _context.Sliders
                .Where(s => !s.IsDeleted)
                .OrderBy(s => s.Order)
                .Take(2)
                .ToListAsync();


            List<Product> products = await _context.Products
                .Where(p => !p.IsDeleted)
                .Take(2)
                .Include(p=>p.ProductImages.Where(pi=>pi.IsPrimary!=null))
                .ToListAsync();


            HomeVm homevm = new()
            {
                Sliders = sliders,
                Products = products   
            };

            return View( homevm);
        }

    }
}
