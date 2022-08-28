using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dgPadCms.Models
{
    public class PostType
    {
        public int PostTypeId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Code { get; set; }
        public List<Taxonomy> TaxonomyList { get; set; }
    }
}
