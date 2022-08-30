using dgPadCms.Infrastructure;
using Microsoft.AspNetCore.Mvc;
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

        // GET /admin/posts/create
        public IActionResult Create()
        {
            return View();
        }
    }
}
