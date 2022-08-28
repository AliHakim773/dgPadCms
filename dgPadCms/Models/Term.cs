using System.ComponentModel.DataAnnotations;

namespace dgPadCms.Models
{
    public class Term
    {
        public int TermId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
        [Required]
        public int TaxonomyId { get; set; }
    }
}
