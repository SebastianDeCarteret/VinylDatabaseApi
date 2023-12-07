using System.Globalization;
using VinylDatabaseApi.Models;

namespace VinylDatabaseApi
{
    public static class SeedData

    {
        readonly public static List<Vinyl> SeedDataList =
        [
            new Vinyl
            {
                Band = new Band
                {
                    Name = "Bon Jovi",
                    FormedDate = new DateOnly(1975, 4, 17),
                },
                Title = "Slippery When Wet",
                NumberOfTracks = 16,
                NumberOfLps = 2,
                Price = 39.99f,
                ReleaseDate = new DateOnly(1982, 3, 18),
                ImageLink = "Link",
                Tracks = new List<Track>([
                new Track
                {
                    Title = "BJ1",
                    Length = 3.34f,
                },
                    new Track
                    {
                        Title = "BJ2",
                        Length = 2.45f,
                    }
                ])
            },
            new Vinyl
            {
                Band = new Band
                {
                    Name = "AC/DC",
                    FormedDate = new DateOnly(1975, 4, 17),
                },
                Title = "Back In Black",
                NumberOfTracks = 8,
                NumberOfLps = 1,
                Price = 19.99f,
                ReleaseDate = new DateOnly(1982, 3, 1),
                ImageLink = "Link",
                Tracks = new List<Track>([
                new Track
                {
                    Title = "AC1",
                    Length = 4.3f,
                },
                    new Track
                    {
                        Title = "AC2",
                        Length = 3.33f,
                    }
                ])
            },
            new Vinyl
            {
                Artist = new Artist
                {
                    FirstName = "Ace",
                    LastName = "Freehly",
                    BirthdateDate = new DateOnly(1943, 3, 29)

                },
                Title = "Ace Freehly 1",
                NumberOfTracks = 8,
                NumberOfLps = 1,
                Price = 19.99f,
                ReleaseDate = new DateOnly(1982, 3, 1),
                ImageLink = "Link",
                Tracks = new List<Track>([
                new Track
                {
                    Title = "AF1",
                    Length = 4.3f,
                },
                    new Track
                    {
                        Title = "AF2",
                        Length = 3.33f,
                    }
                ])
            }
        ];
    }
}
