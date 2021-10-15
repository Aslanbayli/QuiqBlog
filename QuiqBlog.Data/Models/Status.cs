using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class Status
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // Relationships
        public List<Post> Posts { get; set; }

        public List<Category> Categories { get; set; }
    }
}
