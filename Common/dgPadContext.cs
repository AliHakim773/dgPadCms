using dgPadCms.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Common
{
    public class dgPadContext : IdentityDbContext<AppUser>
    {
        public dgPadContext(DbContextOptions<dgPadContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Taxonomy();
            builder.Term();
            builder.PostType();
            builder.TaxonomyPostType();
            builder.Post();
            builder.PostTerm();
        }

        public DbSet<Taxonomy> Taxonomies { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TaxonomyPostType> TaxonomyPostTypes { get; set; }
        public DbSet<PostTerm> PostTerms { get; set; }

    }
}
