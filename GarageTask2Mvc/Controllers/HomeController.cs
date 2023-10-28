using GarageTask2Mvc.Models;
using GarageTask2Mvc.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace GarageTask2Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var prjectComponent = new List<ProjectComponent>
            {
                new ProjectComponent {Id=1, Title="UI/UX design", Description="UI text", ImagePath="/assets/img/services-01.jpg"},
                new ProjectComponent {Id=2, Title="Social media", Description="Sosial media text", ImagePath="/assets/img/services-02.jpg" },
                new ProjectComponent {Id=3, Title="Marketing", Description="Marketing text", ImagePath="/assets/img/services-03.jpg" },
                new ProjectComponent {Id=4, Title="Design", Description="Design text", ImagePath="/assets/img/services-04.jpg" },
            };
            var recentWork = new List<RecentWorks>
            {
                  new RecentWorks {Id=1, Title="Social Media", Description="Soasial media text", ImagePath="/assets/img/recent-work-01.jpg"},
                  new RecentWorks {Id=2, Title="Web Marketing", Description="Web marketing text", ImagePath="/assets/img/recent-work-02.jpg"},
                  new RecentWorks {Id=3, Title="R & D", Description="R & D text", ImagePath="/assets/img/recent-work-03.jpg" },
                  new RecentWorks {Id=4, Title="Public Relation", Description="Public relation text", ImagePath="/assets/img/recent-work-04.jpg"},
                  new RecentWorks {Id=5, Title="Brading", Description="Branding text", ImagePath="/assets/img/recent-work-05.jpg"},
                  new RecentWorks {Id=6, Title="Creative Design", Description="Creative design text", ImagePath="/assets/img/recent-work-06.jpg"},
             
            };
            var vm = new HomeIndexViewModel
            {
                ProjectComponents = prjectComponent,
                RecentWorks = recentWork
            };
            return View(vm);
        }
    }
}
