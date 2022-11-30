using mpsPlatform.Infrastructure.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class ЕquipmentModel
    {
        public ЕquipmentModel()
        {
           SerialNumbers = new List<SerialNumber>();
            SparePartsModels = new List<SparePartModel>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string PartNumber { get; set; } = null!;


        [StringLength(300)]
        public string? ImageUrl { get; set; } = null!;

        [Required]
        public MaxPaperType MaxPaperType { get; set; }

        [Required]
        public EquipmentType EquimpentType { get; set; }

        [Required]
        [ForeignKey(nameof(Мanifacturer))]
        public int МanifacturerId { get; set; }
        public Мanifacturer Мanifacturer { get; set; } = null!;

        public List<SerialNumber> SerialNumbers{ get; set; }

        public List<SparePartModel> SparePartsModels { get; set; }
    }
}
