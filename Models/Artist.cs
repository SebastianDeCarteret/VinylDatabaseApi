using System.ComponentModel.DataAnnotations;

namespace VinylDatabaseApi.Models
{
    public class Artist
    {
        public int Id { get; init; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateOnly BirthdateDate { get; set; }

        public int VinylId { get; init; }
        //public Vinyl Vinyl { get; init; }
    }
}
