using Microsoft.AspNetCore.Mvc;

namespace GarageTask2Mvc.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
