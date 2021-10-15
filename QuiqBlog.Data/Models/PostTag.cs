using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class PostTag
    {
        public int? Id { get; set; }

        public int PostId { get; set; }

        public int TagId { get; set; }

        // Relationships
        public Post Post { get; set; }

        public Tag Tag { get; set; }
    }
}
