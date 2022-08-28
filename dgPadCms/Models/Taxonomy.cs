using System.ComponentModel.DataAnnotations;

namespace dgPadCms.Models
{
    public class Taxonomy
    {
        public int TaxonomyId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
