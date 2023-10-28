using Microsoft.AspNetCore.Mvc;

namespace GarageTask2Mvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
