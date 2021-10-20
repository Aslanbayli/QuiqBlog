using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuiqBlog.Data;
using QuiqBlog.Data.Models;

namespace QuiqBlog.Controllers
{
    public class PostTranslationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostTranslationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PostTranslation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PostTranslation.Include(p => p.ApplicationUser).Include(p => p.Category).Include(p => p.Language).Include(p => p.Post);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PostTranslation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postTranslation = await _context.PostTranslation
                .Include(p => p.ApplicationUser)
                .Include(p => p.Category)
                .Include(p => p.Language)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postTranslation == null)
            {
                return NotFound();
            }

            return View(postTranslation);
        }

        // GET: PostTranslation/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id");
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Id");
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return View("Create");
        }

        // POST: PostTranslation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostId,CategoryId,LanguageId,ApplicationUserId,Title,MetaTitle,Slug,Summary,Body,LastChanged,CreatedAt,PublishedAt")] PostTranslation postTranslation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postTranslation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", postTranslation.ApplicationUserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", postTranslation.CategoryId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Id", postTranslation.LanguageId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postTranslation.PostId);
            return View(postTranslation);
        }

        // GET: PostTranslation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postTranslation = await _context.PostTranslation.FindAsync(id);
            if (postTranslation == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", postTranslation.ApplicationUserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", postTranslation.CategoryId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Id", postTranslation.LanguageId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postTranslation.PostId);
            return View(postTranslation);
        }

        // POST: PostTranslation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PostId,CategoryId,LanguageId,ApplicationUserId,Title,MetaTitle,Slug,Summary,Body,LastChanged,CreatedAt,PublishedAt")] PostTranslation postTranslation)
        {
            if (id != postTranslation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postTranslation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostTranslationExists(postTranslation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", postTranslation.ApplicationUserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", postTranslation.CategoryId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "Id", "Id", postTranslation.LanguageId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postTranslation.PostId);
            return View(postTranslation);
        }

        // GET: PostTranslation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postTranslation = await _context.PostTranslation
                .Include(p => p.ApplicationUser)
                .Include(p => p.Category)
                .Include(p => p.Language)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postTranslation == null)
            {
                return NotFound();
            }

            return View(postTranslation);
        }

        // POST: PostTranslation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var postTranslation = await _context.PostTranslation.FindAsync(id);
            _context.PostTranslation.Remove(postTranslation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostTranslationExists(int id)
        {
            return _context.PostTranslation.Any(e => e.Id == id);
        }
    }
}
