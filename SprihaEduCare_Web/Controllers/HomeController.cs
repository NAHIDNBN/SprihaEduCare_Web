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
        public IActionResult Programs()
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
        public IActionResult Questions()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Suggestions()
        {
            return View();
        }
        public IActionResult QuickTest()
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
