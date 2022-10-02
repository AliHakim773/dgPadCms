using dgPadCms.Models;
using Microsoft.AspNetCore.Identity;
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
            this.SeedUsers(builder);
            this.SeedRoles(builder);
            this.SeedUserRoles(builder);
        }

        public DbSet<Taxonomy> Taxonomies { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TaxonomyPostType> TaxonomyPostTypes { get; set; }
        public DbSet<PostTerm> PostTerms { get; set; }

        private void SeedUsers(ModelBuilder builder)
        {
            AppUser user = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            passwordHasher.HashPassword(user, "Admin");
            user.PasswordHash = passwordHasher.HashPassword(user, "Admin");

            builder.Entity<AppUser>().HasData(user);

            AppUser user2 = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e4",
                UserName = "Editor",
                Email = "Editor@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            PasswordHasher<AppUser> passwordHasher2 = new PasswordHasher<AppUser>();
            passwordHasher2.HashPassword(user2, "Editor");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Editor");

            builder.Entity<AppUser>().HasData(user2);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Editor", ConcurrencyStamp = "2", NormalizedName = "Editor" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
                );
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "b74ddd14-6340-4840-95c2-db12554843e4" }
                );
        }

    }
}
