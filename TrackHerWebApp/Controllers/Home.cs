using Microsoft.AspNetCore.Mvc;
using TrackHer;
using TrackHerWebApp.Models;

namespace TrackHerWebApp.Controllers
{
    public class Home : Controller
    {
        private readonly ILogger<Home> _logger;

        public Home(ILogger<Home> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var symptoms = SymptomRepository.GetAllSymptoms();
            return View(symptoms);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       

    }
}
