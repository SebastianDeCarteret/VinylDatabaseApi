using System.ComponentModel.DataAnnotations;

namespace VinylDatabaseApi.Models
{
    public class Vinyl
    {
        public int Id { get; init; }

        [Required]
        public string Title { get; set; }
        //public int? ArtistId { get; set; }

        public Artist? Artist { get; set; }

        //public int? BandId { get; set; }

        public Band? Band { get; set; }

        [Required]
        public int NumberOfLps { get; set; }

        [Required]
        public int NumberOfTracks { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        public string ImageLink { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
