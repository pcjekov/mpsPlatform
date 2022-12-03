using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class InstallerMan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
