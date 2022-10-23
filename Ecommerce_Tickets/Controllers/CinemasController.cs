using Ecommerce_Tickets.Data;

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Tickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CinemasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
