using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Core.Models
{
    public class ManufacturerModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string Name { get; set; } = null!;
    }
}
