using dgPadCms.Models;
using System.Collections.Generic;

namespace dgPadPosts.Models
{
    public class PostTypesViewModel
    {
        public List<Post> posts { get; set; }
        public List<Taxonomy> taxonomies { get; set; }
        public List<Term> terms { get; set; }
        public Taxonomy taxonomy { get; set; }
    }
}
