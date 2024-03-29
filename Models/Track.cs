﻿using System.ComponentModel.DataAnnotations;

namespace VinylDatabaseApi.Models
{
    public class Track
    {
        public int Id { get; init; }

        [Required]
        public string Title { get; set; }

        [Required]
        public float Length { get; set; }

        public int VinylId { get; init; }
        public Vinyl? Vinyl { get; init; }
    }
}
