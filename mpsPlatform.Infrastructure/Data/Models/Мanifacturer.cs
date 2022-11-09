using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class Мanifacturer
    {
        public Мanifacturer()
        {
            Models = new List<Model>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        public List<Model> Models { get; set; }
    }
}
