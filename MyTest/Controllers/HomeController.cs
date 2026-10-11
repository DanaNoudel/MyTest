using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTest.Models;

namespace MyTest.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context) {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index() {
            var students = await _context.Students
                .Include(s => s.Classroom)
                    .ThenInclude(c => c.School)
                .Include(s => s.Courses)
                .ToListAsync();

            return View(students);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}