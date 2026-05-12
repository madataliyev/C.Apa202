using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.Services;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class ShopController : Controller
    {
        public ShopController(AppDbContext context)
        {
            _context=context;
        }


        private readonly IEmailService _emailService;
        private readonly AppDbContext _context;

        public ShopController(IEmailService emailService)
        {
           _emailService=emailService;
        }

        public async Task<IActionResult> Index()
        {
            List<Product>products = await _context.Products
                .Where(p=>!p.IsDeleted)
                .Include(p=>p.ProductImages .Where(pi=>pi.IsPrimary!=null && pi.IsDeleted==false))
                .ToListAsync();


            ShopVM shopVM = new()
            {
                Products = products
            };


            _emailService.SendEmail();
            return View(shopVM);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id is null || id<1) return View();

          Product? product = await _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p=>p.Category)
                .Include(p=>p.ProductImages)
                .FirstOrDefaultAsync(p=>p.Id== id);

            if(product == null) return NotFound();

            List<Product>relatedProducts= await _context.Products
                .Where(p=>!p.IsDeleted)
                .Where(p=>p.CategoryId==product.CategoryId  && p.Id !=product.Id)
                .Include (p=>p.ProductImages.Where(pi=>pi.IsPrimary!=null && pi.IsDeleted==false))
                .ToListAsync();


            DetailVM detailVM = new()
            {
                Product = product,
                RelatedProducts = relatedProducts
            };

            return View(product);
        }
    }
}
