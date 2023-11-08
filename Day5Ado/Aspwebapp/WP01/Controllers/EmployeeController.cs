using Microsoft.AspNetCore.Mvc;
using WP01.Models;

namespace WP01.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _emprp;
        public EmployeeController(IEmployeeRepository emprp)
        {
            _emprp = emprp;
        }

        public ActionResult Index()
        {
            var emplist= _emprp.GetAllEmployee();
            return View(emplist);
        }
        public ActionResult Display()
        {
            return View();
        }
    }
}
