using FoodOrderApp.Data;
using FoodOrderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FoodOrderApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext Context { get; }

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext _context)
        {
            _logger = logger;
            this.Context = _context;
        }

        public async Task<IActionResult> Index()
        {      
            return View(await Context.Products.Take(3).ToListAsync());          
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}