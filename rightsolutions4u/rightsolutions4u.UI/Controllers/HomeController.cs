using Microsoft.AspNetCore.Mvc;
using rightsolutions4u.UI.Models;
using System.Diagnostics;

namespace rightsolutions4u.UI.Controllers
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

        public IActionResult About()
        {
            return View("../shared/About");
        }
        public IActionResult Contact()
        {
            return View("../shared/Contact");
        }
        public IActionResult Service()
        {
            return View("../shared/Service");
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