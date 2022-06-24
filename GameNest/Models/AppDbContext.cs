using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameNest.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
               : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
        
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Wishlist> Wishlist { get; set; }
    }
}
