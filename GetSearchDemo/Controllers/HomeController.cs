using GetSearchDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GetSearchDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public  IActionResult Index()
        {
            return View(new PersonSearchModel());
        }
        [HttpGet]
        public IActionResult Search(PersonSearchModel model)
        {
            return PartialView("SearchPerson",model);
        }
    }
}