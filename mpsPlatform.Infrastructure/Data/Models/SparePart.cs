using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class SparePart
    {
        public SparePart()
        {
            SparepartsModels = new List<SparepartModel>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string PartNumber { get; set; } = null!;

        [Required]
        public int Resource { get; set; }

        public List<SparepartModel> SparepartsModels { get; set; }
    }
}
