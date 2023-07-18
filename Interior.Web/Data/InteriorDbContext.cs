using Interior.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Interior.Web.Data
{
    public class InteriorDbContext : DbContext
    {
        public InteriorDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Decor> Decors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
