using QuiqBlog.Data.Models;
using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiqBlog.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<PostTranslation> Posts { get; }
        Task<int> Complete();
    }
}
