using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class SerialNumber
    {
        public SerialNumber()
        {
            Counters = new List<Counter>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ЕquipmentSerialNumber { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ЕquipmentModel))]
        public int ЕquipmentModelId { get; set; }
        public ЕquipmentModel ЕquipmentModel { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Contract))]
        public int ContractId { get; set; }
        public Contract Contract { get; set; } = null!;

        [Required]
        [Precision(10, 8)]
        public decimal PriceMonochromeA4 { get; set; }

        [Precision(10, 8)]
        public decimal PriceColorA4 { get; set; }

        [Precision(10, 8)]
        public decimal PriceMonochromeA3 { get; set; }

        [Precision(10, 8)]
        public decimal PriceColorA3 { get; set; }

        public List<Counter> Counters { get; set; }
        
    }
}
