using FoodOrderApp.Data;
using FoodOrderApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace FoodOrderApp.Controllers
{
    public class LoginController : Controller
    {

        private ApplicationDbContext Context { get; }
        public LoginController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckLogin(Admin admin)
        {

            // checks login data from the database
            var status = Context.Admin.Where(m => m.Admin_Email == admin.Admin_Email && m.Admin_Password == admin.Admin_Password).FirstOrDefault();

            // if login is wrong
            if (status == null)
            {
                ViewBag.LoginStatus = 0;
            }
            // if login is successful
            else
            {
                HttpContext.Session.SetString("adminname", "AdminSession");
                return RedirectToAction("Index", "Admin");

            }
            return View("Index");
        }

    }
}
