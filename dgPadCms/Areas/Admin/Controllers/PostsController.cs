using dgPadCms.Infrastructure;
using dgPadCms.Models;
using dgPadCms.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
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
            if (pts == 0)
            {
                ModelState.AddModelError("", "Choose a Post Type");
                ViewBag.PostTypeId = new SelectList(context.PostTypes.OrderBy(x => x.Title), "PostTypeId", "Title");
                return View();
            }
            var pt = await context.PostTypes.FindAsync(pts);
            return RedirectToAction("Create", pt);
        }

        // GET /admin/posts/create
        public async Task<ActionResult> Create(PostType pt)
        {
            ViewBag.PostType = pt;
            var postTypesTaxonomies = await context.TaxonomyPostTypes.Where(x => x.PostTypeId == pt.PostTypeId).Include(x => x.Taxonomy).ToListAsync();
            List<CreatePostViewModel> createPostViewModels = new List<CreatePostViewModel>();
            foreach (var i in postTypesTaxonomies)
            {
                createPostViewModels.Add(new CreatePostViewModel()
                {
                    taxonomy = i.Taxonomy,
                    terms = new SelectList(context.Terms.Where(x => x.TaxonomyId == i.TaxonomyId).Include(x => x.Taxonomy), "TermId", "Name"),
            });
            }
            ViewBag.CreatePostViewModels = createPostViewModels;
            return View();
        }

        // POST /admin/posts/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post, List<int> termIdList)
        {
            post.CreationDate = DateTime.Now.ToString("yyyy - MM - dd hh: mm");

            context.Add(post);
            await context.SaveChangesAsync();

            foreach (var term in termIdList)
            {
                PostTerm postTerm = new PostTerm()
                {
                    TermId = term,
                    PostId = post.PostId,
                };

                context.Add(postTerm);
            }
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
