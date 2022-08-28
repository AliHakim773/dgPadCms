using System;
using System.Collections.Generic;

namespace dgPadCms.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public int PostTypeId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Details { get; set; }
        public string Summary { get; set; }
        public List<Term> TermList { get; set; }
    }
}
