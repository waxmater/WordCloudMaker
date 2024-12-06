using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WordCloudMaker.Models;
using WordCloudMaker.Utils;

namespace WordCloudMaker.Controllers
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
            // Конвертируем 
            string imreBase64Data = Convert.ToBase64String(WordCloudHelper.GenerateWordCloud());
            string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
            ViewBag.ImageData = imgDataURL;
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

        public IActionResult GetImage() 
        {
            return View();
        }
    }
}
