using dgPadCms.Infrastructure;
using dgPadCms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace dgPadCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController : Controller
    {
        private readonly dgPadContext context;
        public PostsController(dgPadContext context)
        {
            this.context = context;
        }


        // GET /admin/posts
        public async Task<IActionResult> Index()
        {
            var posts = await context.Posts.OrderByDescending(p => p.PostId).ToListAsync();
            return View(posts);
        }

        // GET /admin/posts/choose
        public IActionResult Choose()
        {
            ViewBag.PostTypeId = new SelectList(context.PostTypes.OrderBy(x => x.Title), "PostTypeId", "Title");

            return View();
        }

        // POST /admin/posts/choose
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Choose(int pts)
        {
            var pt = await context.PostTypes.FindAsync(pts);
            return RedirectToAction("Create", pt);
        }

        // GET /admin/posts/create
        public ActionResult Create(PostType pt)
        {
            ViewBag.PostType = pt;
            return View();
        }
    }
}
