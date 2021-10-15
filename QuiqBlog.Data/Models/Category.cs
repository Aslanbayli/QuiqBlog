using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public int StatusId { get; set; }

        public string Description { get; set; }

        // Relationships
        public List<CategoryTranslation> CategoryTranslations { get; set; }

        public List<PostTranslation> PostTranslations { get; set; }

        public Status Status { get; set; }
    }
}
