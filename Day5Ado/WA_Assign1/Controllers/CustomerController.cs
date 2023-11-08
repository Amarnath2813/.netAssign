using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using WA_Assign1.Models;

namespace WA_Assign1.Controllers
{
    public class CustomerController : Controller
    {
        ICustomer _customref;
        public CustomerController(ICustomer customref)
        {
            _customref = customref;
        }
       public ActionResult Index()
        {
            var list = _customref.GetAllCustomer();
            return View(list);
        }
    }
}
