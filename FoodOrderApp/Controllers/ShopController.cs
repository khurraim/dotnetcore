using FoodOrderApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderApp.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext Context { get; }
        public ShopController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await Context.Products.ToListAsync());
        }
    }
}
