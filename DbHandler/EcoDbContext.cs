using EcoFriendly.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoFriendly
{
    public class EcoDbContext: DbContext
    {
        public EcoDbContext(DbContextOptions<EcoDbContext> options) : base(options) { }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}