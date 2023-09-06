using DemoMVCReverseEngineering.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoMVCReverseEngineering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INorthwindData northwindData;

        public HomeController(ILogger<HomeController> logger,
            INorthwindData northwindData)
        {
            _logger = logger;
            this.northwindData = northwindData;
        }

        public async Task<IActionResult> Index()
        {
            return View(await northwindData.GetHomeIndexViewModelAsync());
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