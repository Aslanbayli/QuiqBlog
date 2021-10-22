using QuiqBlog.Data;
using QuiqBlog.Data.Models;
using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiqBlog.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        public readonly ApplicationDbContext _context;
        public IGenericRepository<PostTranslation> Posts {  get; }

        public UnitOfWork(ApplicationDbContext applicationDbContext, IGenericRepository<PostTranslation> genericRepository)
        {
            this._context = applicationDbContext;
            this.Posts = genericRepository;
        }


        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
