using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiqBlog.Repositories
{
    interface IUnitOfWork
    {
        Task<int> Complete();
    }
}
