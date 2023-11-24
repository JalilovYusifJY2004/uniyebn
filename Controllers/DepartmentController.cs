using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Department(int id)
        {
            if (id <= 0) return BadRequest();

            Department department = _context.Departments.FirstOrDefault(d => d.Id == id);
            if (department == null) return NotFound();
            List<Department> departments=_context.Departments.ToList();

            return View(department);

        }
        
    }
}
