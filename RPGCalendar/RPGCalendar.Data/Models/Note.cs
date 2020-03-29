using System;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Data.Models
{
    public class Note : GameObject
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
