using System;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Models
{
    public class Notification
    {
        [Required]
        public string Title { get; internal set; }
        [Required]
        public string Description { get; internal set; }

    }
}
