using Microsoft.AspNetCore.Identity;
using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<PostTranslation> PostTranslations { get; set; }

        public ApplicationUser()
        {

        }
    }
}
