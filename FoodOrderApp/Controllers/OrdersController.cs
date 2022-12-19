using FoodOrderApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderApp.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext Context { get; }
        public OrdersController( ApplicationDbContext _context)
        {
            
            this.Context = _context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await Context.Order.ToListAsync());
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var execution = await Context.Order.FindAsync(id);
            Context.Order.Remove(execution);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
