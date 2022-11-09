using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class SparepartModel
    {
        [Required]
        [ForeignKey(nameof(SparePart))]
        public int SparePartId { get; set; }
        public SparePart SparePart { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Model))]
        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;
    }
}
