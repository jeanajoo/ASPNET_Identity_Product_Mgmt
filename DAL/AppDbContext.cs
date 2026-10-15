using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Joo_Jeana_HW4.Models;

namespace Joo_Jeana_HW4.DAL
{

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
        
    }
}