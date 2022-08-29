using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FizzBuzz.Controllers
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

        public IActionResult TheCode()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FizzBuzzPage()
        {
            FizzBuzzModel model = FizzBuzzServices.GetFizzBuzzService();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FizzBuzzPage(FizzBuzzModel fizzBuzz)
        {
            FizzBuzzServices.PostFizzBuzzService(fizzBuzz);

            return View(fizzBuzz);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}