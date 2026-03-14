using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using Microsoft.EntityFrameworkCore; // <-- Add this using directive

namespace StudentManagementSystem.Controllers
{
    public class StudentDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.Course)
                .FirstOrDefault(s => s.Email == email);

            return View(student);
        }
    }
}
