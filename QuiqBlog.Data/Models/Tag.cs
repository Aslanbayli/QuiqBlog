using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }
    }
}
