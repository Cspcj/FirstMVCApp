using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class CodeSnippetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
