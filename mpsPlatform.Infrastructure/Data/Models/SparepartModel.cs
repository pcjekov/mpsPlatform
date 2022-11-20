using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class SparePartModel
    {
        [Required]
        [ForeignKey(nameof(SparePart))]
        public int SparePartId { get; set; }
        public SparePart SparePart { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ЕquipmentModel))]
        public int ЕquipmentModelId { get; set; }
        public ЕquipmentModel ЕquipmentModel { get; set; } = null!;
    }
}
