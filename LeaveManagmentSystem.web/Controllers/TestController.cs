using LeaveManagmentSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagmentSystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(1954,12,01)
            };


            return View(data);
        }
    }
}
