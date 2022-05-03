using Microsoft.AspNetCore.Mvc;

namespace HookahsAndSmokingSystems.Controllers.AdminPanel
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}