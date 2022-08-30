using dgPadCms.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var postTypes = await context.PostTypes
                .OrderByDescending(p => p.PostTypeId)
                .Include(p => p.TaxonomyPostTypes)
                .ThenInclude(p => p.Taxonomy)
                .ToListAsync();

            return View(postTypes);
        }

        // GET /admin/taxonomies/create
        public IActionResult Create() => View();
    }
}
