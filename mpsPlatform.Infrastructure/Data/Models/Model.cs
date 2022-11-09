using mpsPlatform.Infrastructure.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class Model
    {
        public Model()
        {
            EquimpentsSerialNumbers = new List<EquimpentSerialNumber>();
            SparepartsModels = new List<SparepartModel>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;


        [StringLength(300)]
        public string? ImageUrl { get; set; } = null!;

        [Required]
        public MaxPaperType MaxPaperType { get; set; }

        [Required]
        public EquimpentType EquimpentType { get; set; }

        [Required]
        [ForeignKey(nameof(Мanifacturer))]
        public int МanifacturerId { get; set; }
        public Мanifacturer Мanifacturer { get; set; } = null!;

        public List<EquimpentSerialNumber> EquimpentsSerialNumbers{ get; set; }

        public List<SparepartModel> SparepartsModels { get; set; }
    }
}
