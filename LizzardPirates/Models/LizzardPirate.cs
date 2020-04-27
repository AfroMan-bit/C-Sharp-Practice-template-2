using System.ComponentModel.DataAnnotations;
using System;

namespace LizzardPirates.Models
{
    public class LizzardPirate
    {
        [Key]
        public int LizzardPirateId {  get; set;}

        [Required]
        public string Name { get; set; }

        [Required]
        public string LizzardType { get; set; }

        [Required]
        public string PirateRole { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}