using Microsoft.AspNetCore.Mvc;

namespace WP01.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
