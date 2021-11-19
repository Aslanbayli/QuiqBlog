using QuiqBlog.Data.Models;

namespace QuiqBlog.ViewModels
{
    public class PostCreateViewModel
    {
        public int Id {  get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Summary { get; set; }

        public string Body { get; set; }
    }
}
