using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Weather_API.Data
{
    public class DatabaseContext: IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

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
                    NormalizedName = "Admin"
                }
                );
        }
    }
}
