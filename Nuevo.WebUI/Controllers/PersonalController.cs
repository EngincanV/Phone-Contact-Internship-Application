using Microsoft.AspNetCore.Mvc;

namespace Nuevo.WebUI.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Detail(int? id)
        {
            return View();
        }
    }
}