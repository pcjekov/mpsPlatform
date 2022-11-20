using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            ЕquipmentLocations = new List<ЕquipmentLocation>();
            Contracts = new List<Contract>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public List<ЕquipmentLocation> ЕquipmentLocations { get; set; }

        public List<Contract> Contracts { get; set; }
    }
}
