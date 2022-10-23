using Ecommerce_Tickets.Data;

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Tickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProducersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
