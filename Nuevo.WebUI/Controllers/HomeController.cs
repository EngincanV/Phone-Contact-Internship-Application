using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nuevo.Business.Abstract;
using Nuevo.WebUI.Models;

namespace Nuevo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonalService _personalService;

        public HomeController(ILogger<HomeController> logger, IPersonalService personalService)
        {
            _logger = logger;
            _personalService = personalService;
        }

        public IActionResult Index()
        {
            var getPersonals = _personalService.GetAll();

            return View(getPersonals);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
