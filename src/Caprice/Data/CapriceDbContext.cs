using Caprice.Models;
using Microsoft.EntityFrameworkCore;

namespace Caprice.Data
{
    public class CapriceDbContext : DbContext
    {
        public CapriceDbContext(DbContextOptions<CapriceDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
