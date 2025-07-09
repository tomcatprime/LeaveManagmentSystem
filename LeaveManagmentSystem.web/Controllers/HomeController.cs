using System.Diagnostics;
using LeaveManagmentSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagmentSystem.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // Injecting the logger, 
                                                          // which is used for logging information, warnings, and errors.

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Define business logic here, if any.
            return View();  // Returns the default view for the Index action.
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
