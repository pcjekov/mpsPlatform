using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class CounterMonochromeA4
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CurrentCounter { get; set; }

        [Required]
        [ForeignKey(nameof(SerialNumber))]
        public int SerialNumberId { get; set; }
        public SerialNumber SerialNumber { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(DateOfEntry))]
        public int DateOfEntryId { get; set; }
        public DateOfEntry DateOfEntry { get; set; } = null!;
    }
}
