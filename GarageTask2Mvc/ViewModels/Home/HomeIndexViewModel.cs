using GarageTask2Mvc.Models;

namespace GarageTask2Mvc.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public List<ProjectComponent> ProjectComponents { get; set; }
        public List<RecentWorks> RecentWorks { get; set; }
    }
}
