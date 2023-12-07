using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using VinylDatabaseApi.Models;

namespace VinylDatabaseApi.Data
{
    public class VinylDatabaseApiContext : DbContext
    {
        public VinylDatabaseApiContext(DbContextOptions<VinylDatabaseApiContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Vinyl>()
        //        .HasOne<Band>()
        //        .HasOne
        //}

        public DbSet<Vinyl> Vinyl { get; set; } = default!;
        public DbSet<Track> Tracks { get; set; } = default!;
        public DbSet<VinylDatabaseApi.Models.Band> Band { get; set; } = default!;
    }
}

