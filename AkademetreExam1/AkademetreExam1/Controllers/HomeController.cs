using AkademetreExam1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AkademetreExam1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveFormData(string name, string surname, string address, string email)
        {
            
            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetString("Surname", surname);
            HttpContext.Session.SetString("Address", address);
            HttpContext.Session.SetString("E-mail", email);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}