using Microsoft.AspNetCore.Mvc;
using SprihaEduCare_Web.Models;
using System.Diagnostics;

namespace SprihaEduCare_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutSpriha()
        {
            return View();
        }
        public IActionResult OurProgram()
        {
            return View();
        }
        public IActionResult Teachers()
        {
            return View();
        }
        public IActionResult EvaluateYourself()
        {
            return View();
        }
        public IActionResult AdviceOfSSC()
        {
            return View();
        }
        public IActionResult AdviceOfHSC()
        {
            return View();
        }
        public IActionResult YourQuestion()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
