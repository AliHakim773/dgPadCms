using Microsoft.AspNetCore.Mvc;

namespace dgPadCms.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
