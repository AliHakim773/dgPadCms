using System.Collections.Generic;

namespace dgPadCms.Models.ViewModels
{
    public class PostTypeEditViewModel
    {
        public PostType postType { get; set; }
        public List<int> taxonomyIdList { get; set; }
    }
}
