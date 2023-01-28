using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Weather_API.Models;

namespace Weather_API.Data
{
    public class DatabaseContext: IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {

        }

        public DbSet<Weather> weather { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Weather>(entity =>
            {
                entity.HasKey(u=>u.Id);

            });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id= "3fcffc8c-cb7c-4b83-b201-347fa2b4263f",
                    Name="User",
                    NormalizedName="USER"
                },
                new IdentityRole
                {
                    Id = "e9a390cc-138f-4011-814f-f5f79df8ceb7",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
                );
            var hasher = new PasswordHasher<User>();

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "8e448afa-f008-446e-a52f-13c449803c2e",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    FirstName = "solo",
                    LastName = "makinde",
                    PasswordHash = hasher.HashPassword(null, "87654321")
                },
                new User
                {
                    Id = "30a24107-d279-4e37-96fd-01af5b38cb27",
                    Email = "jabikem@gmail.com",
                    NormalizedEmail = "JABIKEM@GMAIL.COM",
                    UserName = "jabikem@gmail.com",
                    NormalizedUserName = "JABIKEM@GMAIL.COM",
                    FirstName = "ikechukwu",
                    LastName = "iwuchukwu",
                    PasswordHash = hasher.HashPassword(null, "12345678")
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e9a390cc-138f-4011-814f-f5f79df8ceb7",
                    UserId = "8e448afa-f008-446e-a52f-13c449803c2e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3fcffc8c-cb7c-4b83-b201-347fa2b4263f",
                    UserId = "30a24107-d279-4e37-96fd-01af5b38cb27"
                }
            );
        }
    }
}
