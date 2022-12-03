using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class Contract
    {
        public Contract()
        {
            SerialNumbers = new List<SerialNumber>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractNumber { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<SerialNumber> SerialNumbers { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
