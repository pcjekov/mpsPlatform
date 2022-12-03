using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            Locations = new List<Location>();
            Contracts = new List<Contract>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public List<Location> Locations { get; set; }

        public List<Contract> Contracts { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
