using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using Services;

namespace DIApplication.Controllers
{
    public class HomeController : Controller
    {
        //Dependency injection - Contructor injection
        private readonly ICitiesService _citiesService;
        public HomeController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }

        //Traditional method
        //private readonly CitiesService _citiesService;

        //public HomeController()
        //{
        //    _citiesService = new CitiesService();
        //}

        [Route("/")]
        public IActionResult Index()
        {
            List<String> listOfCities = _citiesService.GetCities();
            return View(listOfCities);
        }
        //Method injection
        [Route("details")]
        public IActionResult Details([FromServices] ICitiesService _citiesService)
        {
            List<String> listOfCities = _citiesService.GetCities();
            return View("index",listOfCities);
        }
    }
}
