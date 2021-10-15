using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class PostTranslation
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int CategoryId { get; set; }

        public int LanguageId { get; set; }

        public int ApplicationUserId { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }

        public string Summary { get; set; }

        public string Body { get; set; }

        public DateTime? LastChanged { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? PublishedAt { get; set; }

        // Relationships
        public Category Category { get; set; }

        public Language Language { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Post Post { get; set; }
    }
}
