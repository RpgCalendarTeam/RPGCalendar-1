using System;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Data.Models
{
    public class Item : GameObject
    {
        [Required]
        public string Name { get; internal set; }
        [Required]
        public string Description { get; internal set; }
        [Required]
        public double Quantity { get; internal set; }
        [Required]
        public double Quality { get; internal set; }
        [Required]
        public double QuanityDegration { get; internal set; }
        [Required]
        public double QualityDegration { get; internal set; }
        [Required]
        public string Player { get; internal set; }
    }
}
