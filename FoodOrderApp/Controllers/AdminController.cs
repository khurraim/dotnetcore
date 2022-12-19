using FoodOrderApp.Data;
using FoodOrderApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderApp.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbContext Context { get; }
        public AdminController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("adminname");
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult SaveOrder(Order order)
        {
            this.Context.Order.Add(order);
            this.Context.SaveChanges();

            return View();
        }
    }
}
