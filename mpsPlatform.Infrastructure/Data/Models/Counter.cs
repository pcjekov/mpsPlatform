using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class Counter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MonochromeA4 { get; set; }

        //[Required]
        public int MonochromeA3 { get; set; }

        //[Required]
        public int ColorA4 { get; set; }

        //[Required]
        public int ColorA3 { get; set; }

        [Required]
        public DateTime DateOfCounter { get; set; }

        [Required]
        [ForeignKey(nameof(SerialNumber))]
        public int SerialNumberId { get; set; }
        public SerialNumber SerialNumber { get; set; } = null!;

        
    }
}
