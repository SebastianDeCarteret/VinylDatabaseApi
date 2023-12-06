namespace VinylDatabaseApi.Models
{
    public class Vinyl
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int NumberOfLps { get; set; }
        public int NumberOfTracks { get; set; }
        public float Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageLink { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
