using dgPadCms.Infrastructure;
using dgPadCms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dgPadCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostTypesController : Controller
    {
        private readonly dgPadContext context;
        public PostTypesController(dgPadContext context)
        {
            this.context = context;
        }


        // GET /admin/posttypes
        public async Task<IActionResult> Index()
        {
            var postTypes = await context.PostTypes.Include(x => x.TaxonomyPostTypes).ThenInclude(x => x.Taxonomy).ToListAsync();
            return View(postTypes);
        }

        // GET /admin/posttypes/create
        public async Task<IActionResult> Create()
        { 

            ViewBag.taxonomies = await context.Taxonomies.ToListAsync();

            return View();
        }

        // POST /admin/posttypes/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostType postType, List<int> taxonomyIdList)
        {
            if (!ModelState.IsValid)
            {
                return View(postType);
            }
            if (taxonomyIdList == null) return View(postType);



            context.Add(postType);
            await context.SaveChangesAsync();

            foreach (var taxonomy in taxonomyIdList)
            {
                TaxonomyPostType taxonomyPostType = new TaxonomyPostType()
                {
                    TaxonomyId = taxonomy,
                    PostTypeId = postType.PostTypeId,
                };

                context.Add(taxonomyPostType);
            }

            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // GET /admin/posttypes/edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var postType = await context.PostTypes.FindAsync(id);
            //var postTypeTaxonomy = await context.PostTypes
            //    .Where(x => x.PostTypeId == id)
            //    //.Include(x => x.TaxonomyPostTypes)
            //    .ToListAsync();
            ViewBag.taxonomies = await context.Taxonomies.ToListAsync();

            ////var shit = await context.Tax

            ////var test = await context.PostTypes
            ////    //.Where(x => x.PostTypeId == id)
            ////    .Include(x => x.TaxonomyPostTypes)
            ////    .ThenInclude(x => x.Taxonomy)
            ////    .FirstOrDefaultAsync(x => x.PostTypeId == id);
            ////List<int> shi = new List<int>();
            ////var test2 = test.Select(x => x.TaxonomyPostTypes);
            ////foreach ( var i in test2)
            ////{
            ////    foreach ( var t in i)
            ////    {
            ////        shi.Add(t.TaxonomyId);
            ////    }
            ////}
            //List<int> shi = new List<int>();

            //foreach ( var i in test.TaxonomyPostTypes)
            //{
            //    shi.Add(i.TaxonomyId);
            //}
            //ViewBag.shi = shi;
            return View(postType);
        }
    }
}
