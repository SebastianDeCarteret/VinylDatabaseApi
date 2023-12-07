using System.ComponentModel.DataAnnotations;

namespace VinylDatabaseApi.Models
{
    public class Band
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateOnly FormedDate { get; set; }

        //[Required]
        public int VinylId { get; init; }
        //public Vinyl Vinyl { get; init; }
    }
}
