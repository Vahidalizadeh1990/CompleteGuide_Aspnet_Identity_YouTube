using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Aspnet_Identity.Models.SeedDefaultUser
{
    // Seed User
    public static class SeedDefaultUser
    {
        public static void RegisterDefaultUser(ModelBuilder modelBuilder)
        {
            var user = UserInfo();
            var adminRole = RoleAdmin();
            var userRoles = RoleUser();
            var userRole = UserRole(user.Id, adminRole.Id);
            modelBuilder.Entity<IdentityUser>().HasData(user);
            modelBuilder.Entity<IdentityRole>().HasData(adminRole, userRoles);
            // User HasNoKey() since the userId and RoleId is a unique foreign key in a many-to-many relationship
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey().HasData(userRole);
        }

        // Add User
        private static IdentityUser UserInfo()
        {
            var user = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "admin@admin.com",
                EmailConfirmed = true,
                UserName = "admin@admin.com"
            };

            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = hasher.HashPassword(user, "admin_1234");
            
            return user;
        }

        // Add Admin Role
        private static IdentityRole RoleAdmin()
        {

            var role = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin"  ,
                NormalizedName = "Admin"
            };

            return role;
        }
        // Add Admin Role
        private static IdentityRole RoleUser()
        {

            var role = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "user",
                NormalizedName = "User"
            };

            return role;
        }

        // Add User Role
        private static IdentityUserRole<string> UserRole(string userId, string roleId)
        {
            var userRole = new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            };
            return userRole;
        }
    }
}
