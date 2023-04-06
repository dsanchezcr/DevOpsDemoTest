using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<WebApp.Models.Item> Item { get; set; } = default!;
    }
}