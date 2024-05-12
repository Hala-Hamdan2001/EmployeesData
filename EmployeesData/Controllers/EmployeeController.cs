using EmployeesData.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesData.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("Index",employees);
        }
    }
}
