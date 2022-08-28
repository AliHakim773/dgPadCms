using Microsoft.AspNetCore.Mvc;

namespace dgPadCms.Areas.Admin.Controllers
{
    public class TaxonomiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
