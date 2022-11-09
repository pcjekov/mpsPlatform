using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class ЕquipmentLocation
    {
        public ЕquipmentLocation()
        {
            EquimpentsSerialNumbers = new List<EquimpentSerialNumber>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<EquimpentSerialNumber> EquimpentsSerialNumbers { get; set; }
    }
}
