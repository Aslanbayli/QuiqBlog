using QuiqBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiqBlog.Models
{
    public class Post
    {

        public int Id { get; set; }

        public int StatusId { get; set; }

        public string Description { get; set; }

        // Relationships
        public List<PostTranslation> PostTranslations { get; set; }

        public List<PostTag> PostTags { get; set; }

        public Status Status { get; set; }

    }
}
