using dgPadCms.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dgPadCms.Infrastructure
{
    public class dgPadContext : IdentityDbContext<AppUser>
    {
        public dgPadContext(DbContextOptions<dgPadContext> options)
            : base(options) { }
    }
}
