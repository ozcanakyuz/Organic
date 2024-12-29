using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organic.EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
    }
}
