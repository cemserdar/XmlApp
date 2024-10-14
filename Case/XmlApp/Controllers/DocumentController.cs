using Microsoft.AspNetCore.Mvc;

namespace XmlApp.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
