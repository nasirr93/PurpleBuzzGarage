using Microsoft.AspNetCore.Mvc;

namespace GarageTask2Mvc.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
