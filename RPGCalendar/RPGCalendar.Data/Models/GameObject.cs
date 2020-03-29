using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Data.Models
{
    public class GameObject : FingerPrintEntityBase
    {
        [Required]
        string GameId { get; set; }
        [Required]
        string Permission { get; set; }
    }
}
