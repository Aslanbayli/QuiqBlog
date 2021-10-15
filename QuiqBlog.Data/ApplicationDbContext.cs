using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuiqBlog.Data.Models;
using QuiqBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PostTranslation>()
                .HasOne(p => p.Post)
                .WithMany(t => t.PostTranslations)
                .HasForeignKey(k => k.PostId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<Language> Language { get; set; }

        public virtual DbSet<CategoryTranslation> CategoryTranslation { get; set; }

        public virtual DbSet<PostTranslation> PostTranslation { get; set; }

        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }

        public virtual DbSet<Post> Post { get; set; }

        public virtual DbSet<Tag> Tag { get; set; }

        public virtual DbSet<PostTag> PostTag { get; set; }

        public virtual DbSet<Status> Status { get; set; }
    }
}

