using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using VinylDatabaseApi.Models;

namespace VinylDatabaseApi.Data
{
    public class VinylDatabaseApiContext : DbContext
    {
        public VinylDatabaseApiContext(DbContextOptions<VinylDatabaseApiContext> options)
            : base(options)
        {
        }

        public DbSet<VinylDatabaseApi.Models.Vinyl> Vinyl { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vinyl>()
                .HasMany(e => e.Tracks)
                .WithOne(e => e.Vinyl)
                .HasForeignKey(e => e.VinylId)
                .HasPrincipalKey(e => e.VinylId);
            Console.WriteLine("test");
            //    modelBuilder.Entity<Vinyl>()
            //.ToTable("Vinyl", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<Vinyl>().HasData(
                    new Vinyl
                    {
                        VinylId = 1,
                        Artist = "Bon Jovi",
                        Title = "Slippery When Wet",
                        NumberOfTracks = 16,
                        NumberOfLps = 2,
                        Price = 39.99f,
                        ReleaseDate = new DateTime(1982, 3, 18, new GregorianCalendar()),
                        ImageLink = "Link",
                    }
                );
            //modelBuilder.Entity<Track>().HasData(
            //    new Track
            //    {
            //        TrackId = 1,
            //        VinylId = 1,
            //        Length = 1,
            //        Title = "Title"
            //    }
            //    );
        }

    }
}

