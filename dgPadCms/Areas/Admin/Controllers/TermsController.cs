using Microsoft.AspNetCore.Mvc;

namespace dgPadCms.Areas.Admin.Controllers
{
    public class TermsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
