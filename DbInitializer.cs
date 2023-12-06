using VinylDatabaseApi.Data;

namespace VinylDatabaseApi
{
    internal class DbInitializer
    {
        internal static void Initialize(VinylDatabaseApiContext dbContext)
        {
            //ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
            //dbContext.SaveChanges();
            //if (dbContext.Vinyl.Any()) return;

            //var vinyls = new Vinyl[]
            //{
            //    new Vinyl
            //{
            //    Artist = "Bon Jovi",
            //    Title = "Slippery When Wet",
            //    NumberOfTracks = 16,
            //    NumberOfLps = 2,
            //    Price = 39.99f,
            //    ReleaseDate = new DateTime(1982, 3, 18, new GregorianCalendar()),
            //    ImageLink = "Link",
            //    Tracks = new List<Track>([
            //    new Track
            //    {
            //        Title = "BJ1",
            //        Length = 3.34f,
            //    },
            //        new Track
            //        {
            //            Title = "BJ2",
            //            Length = 2.45f,
            //        }
            //    ])
            //},
            //new Vinyl
            //{
            //    Artist = "AC/DC",
            //    Title = "Back In Black",
            //    NumberOfTracks = 8,
            //    NumberOfLps = 1,
            //    Price = 19.99f,
            //    ReleaseDate = new DateTime(1982, 3, 1, new GregorianCalendar()),
            //    ImageLink = "Link",
            //    Tracks = new List<Track>([
            //    new Track
            //    {
            //        Title = "AC1",
            //        Length = 4.3f,
            //    },
            //        new Track
            //        {
            //            Title = "AC2",
            //            Length = 3.33f,
            //        }])
            //}
            //};

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            dbContext.SaveChanges();

            dbContext.AddRange(SeedData.SeedDataList
            //    [
            //    new Vinyl
            //    {
            //        Artist = "Bon Jovi",
            //        Title = "Slippery When Wet",
            //        NumberOfTracks = 16,
            //        NumberOfLps = 2,
            //        Price = 39.99f,
            //        ReleaseDate = new DateTime(1982, 3, 18, new GregorianCalendar()),
            //        ImageLink = "Link",
            //        Tracks = new List<Track>([
            //    new Track
            //    {
            //        Title = "BJ1",
            //        Length = 3.34f,
            //    },
            //            new Track
            //            {
            //                Title = "BJ2",
            //                Length = 2.45f,
            //            }
            //    ])
            //    },
            //    new Vinyl
            //    {
            //        Artist = "AC/DC",
            //        Title = "Back In Black",
            //        NumberOfTracks = 8,
            //        NumberOfLps = 1,
            //        Price = 19.99f,
            //        ReleaseDate = new DateTime(1982, 3, 1, new GregorianCalendar()),
            //        ImageLink = "Link",
            //        Tracks = new List<Track>([
            //    new Track
            //    {
            //        Title = "AC1",
            //        Length = 4.3f,
            //    },
            //            new Track
            //            {
            //                Title = "AC2",
            //                Length = 3.33f,
            //            }])
            //    }
            //]);
            );
            //foreach (var vinyl in vinyls)
            //    dbContext.Vinyl.Add(vinyl);

            dbContext.SaveChanges();
        }
    }
}
