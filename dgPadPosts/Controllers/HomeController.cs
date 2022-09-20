using dgPadCms.Infrastructure;
using dgPadCms.Models;
using dgPadPosts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dgPadPosts.Controllers
{
    public class HomeController : Controller
    {
        private readonly dgPadContext context;
        public HomeController(dgPadContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<PostsOfPostTypes> pop = new List<PostsOfPostTypes>();
            var pt = await context.PostTypes.OrderBy(x => x.Title).Take(3).ToListAsync();
            foreach(var p in pt)
            {
                pop.Add(new PostsOfPostTypes()
                {
                    postType = p,
                    posts = await context.Posts
                    .Include(x => x.PostType)
                    .Where(x => x.PostTypeId == p.PostTypeId)
                    .Take(4)
                    .ToListAsync()
                });
            }

            return View(new IndexViewModel()
            {
                carousel = await context.Posts
                .OrderByDescending(x => x.PostId)
                .Take(4).ToListAsync(),

                posts = await context.Posts
                .OrderByDescending(x => x.PostId)
                .Skip(4).Take(7)
                .ToListAsync(),

                postsOfPostTypes = pop
            });
        }

        public async Task<IActionResult> PostTypes(int id)
        {

            var postType = await context.PostTypes.FindAsync(id);

            var postTypesTaxonomies = await context.TaxonomyPostTypes
                .Where(x => x.PostTypeId == id)
                .ToListAsync();

            List<int> taxonomiesId = new List<int>();

            foreach (var i in postTypesTaxonomies)
            {
                taxonomiesId.Add(i.TaxonomyId);
            }

            var terms = await context.Terms
                .Where(x => taxonomiesId.Contains(x.TaxonomyId))
                .ToListAsync();

            return View(new PostTypesViewModel()
            {
                posts = await context.Posts
                .Where(x => x.PostTypeId == id)
                .OrderByDescending(x => x.PostId)
                .ToListAsync(),
                postType = postType,
                terms = terms,
                postTypes = await context.PostTypes
                .OrderByDescending(x => x.PostTypeId)
                .ToListAsync(),
            });
        }

        public async Task<IActionResult> PostDetails (int id)
        {
            Post post = await context.Posts.FindAsync(id);
            ViewBag.PostType = await context.PostTypes.FindAsync(post.PostTypeId);

            var postTerms = await context.PostTerms
                .Where(x => x.PostId == id)
                .ToListAsync();

            List<int> termsIds = new List<int>();

            foreach (var i in postTerms)
            {
                termsIds.Add(i.TermId);
            }

            ViewBag.Terms = await context.Terms
                .Where(x => termsIds.Contains(x.TermId))
                .ToListAsync();

            return View(post);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
