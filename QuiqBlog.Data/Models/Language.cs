using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class Language
    {
        public int Id { get; set; }

        public string LanguageCode { get; set; }

        public string Name { get; set; }

        // Relationships
        public List<CategoryTranslation> CategoryTranslations { get; set; }

        public List<PostTranslation> PostTranslations { get; set; }
    }
}
