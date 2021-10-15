using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class CategoryTranslation
    {
        public int? Id { get; set; }

        public int CategoryId { get; set; }

        public int LanguageId { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }

        public string Body { get; set; }

        // Relationships
        public Category Category { get; set; }

        public Language Language { get; set; }
    }
}
