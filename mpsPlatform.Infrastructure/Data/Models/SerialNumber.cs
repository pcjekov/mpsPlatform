using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class SerialNumber
    {
        public SerialNumber()
        {
            CountersMonochromeA4 = new List<CounterMonochromeA4>();
            CountersMonochromeA3 = new List<CounterMonochromeA3>();
            CountersColorA4 = new List<CounterColorA4>();
            CountersColorA3 = new List<CounterColorA3>();
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

        public List<CounterMonochromeA4> CountersMonochromeA4 { get; set; }
        public List<CounterMonochromeA3> CountersMonochromeA3 { get; set; }
        public List<CounterColorA4> CountersColorA4 { get; set; }
        public List<CounterColorA3> CountersColorA3 { get; set; }
    }
}
