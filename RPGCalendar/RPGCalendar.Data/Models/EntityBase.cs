using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Data.Models
{
    public class EntityBase
    {
        [Required]
        public int Id { get; protected set; }
    }
}
