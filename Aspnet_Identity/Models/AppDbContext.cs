using Aspnet_Identity.Models.SeedDefaultUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aspnet_Identity.Models
{
    // DbContext
    // Instead of inherit DbContext, use IdentityDbContext
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // OnModelCreating
        // Seed method is calling here
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Seed Data
            SeedDefaultUser.SeedDefaultUser.RegisterDefaultUser(builder);
            base.OnModelCreating(builder);
        }
    }
}
