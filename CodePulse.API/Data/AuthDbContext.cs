using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CodePulse.API.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "226a08be-116a-444c-b7e0-93b76e562a76";
            var writerRoleId = "1ae9e6ca-2c63-4c7d-81ba-b0ec142e9ca0";

            //Create reader and writer role
            var roles = new List<IdentityRole>
            {
               new IdentityRole()
               {
                   Id = readerRoleId,
                   Name = "Reader",
                   NormalizedName = "Reader".ToUpper(),
                   ConcurrencyStamp = readerRoleId
               },

               new IdentityRole()
               {
                   Id = writerRoleId,
                   Name = "Writer",
                   NormalizedName = "Writer".ToUpper(),
                   ConcurrencyStamp = writerRoleId
               }
            };

            //seed the roles
            builder.Entity<IdentityRole>().HasData(roles);

            //Create an admin user
            var adminUserId = "78c40edf-7bf2-47de-b54a-f8f980553fc3";

            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "admin@codepulse.com",
                Email = "admin@codepulse.com",
                NormalizedEmail = "admin@codepulse.com".ToUpper(),
                NormalizedUserName = "admin@codepulse.com".ToUpper()
            };

            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Admin@55");
            builder.Entity<IdentityUser>().HasData(admin);


            //Give role(s) to admin user
            var adminRoles = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = adminUserId,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = adminUserId,
                    RoleId = writerRoleId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

    }
}
