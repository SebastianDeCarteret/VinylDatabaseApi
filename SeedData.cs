using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VinylDatabaseApi.Models;

namespace VinylDatabaseApi
{
    public static class SeedData

    {
        readonly public static List<Vinyl> SeedDataList =
        [
            new Vinyl
            {
                Artist = "Bon Jovi",
                Title = "Slippery When Wet",
                NumberOfTracks = 16,
                NumberOfLps = 2,
                Price = 39.99f,
                ReleaseDate = new DateTime(1982, 3, 18, new GregorianCalendar()),
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
                Artist = "AC/DC",
                Title = "Back In Black",
                NumberOfTracks = 8,
                NumberOfLps = 1,
                Price = 19.99f,
                ReleaseDate = new DateTime(1982, 3, 1, new GregorianCalendar()),
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
            }
        ];
    }
}
