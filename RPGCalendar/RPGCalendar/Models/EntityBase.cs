using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Models
{
    public class EntityBase
    {
        [Required]
        public int Id { get; protected set; }
    }
}
