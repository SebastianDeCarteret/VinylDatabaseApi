using Microsoft.EntityFrameworkCore;
using VinylDatabaseApi.Models;

namespace VinylDatabaseApi.Data
{
    public class VinylDatabaseApiContext : DbContext
    {
        public VinylDatabaseApiContext(DbContextOptions<VinylDatabaseApiContext> options)
            : base(options)
        {
        }

        public DbSet<Vinyl> Vinyl { get; set; } = default!;
    }
}

