using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace dgPadCms.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Editor, Admin")]
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
