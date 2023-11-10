using Microsoft.AspNetCore.Mvc;

namespace WA_Cookieexample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            string key = "DemoCookie";
            string value = "Amar";

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append(key, value, options);
            return View();
        }
        public IActionResult Read() {
            string key = "DemoCookie";
            var CookieValue = Request.Cookies[key];
            ViewBag.CookieValue = CookieValue;
            return View();
        }
        public IActionResult Remove()
        {
            string key = "";
            string value = DateTime.Now.ToString();

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Append(key, value, options);

            return View();
        }
    }
}
