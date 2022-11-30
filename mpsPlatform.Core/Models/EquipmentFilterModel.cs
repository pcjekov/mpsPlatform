using mpsPlatform.Models;
using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Core.Models
{
    public class EquipmentFilterModel
    {
        [Display(Name = "Manifacturer")]
        public string? ManifacturerName { get; set; }

        [Display(Name = "Model")]
        public string? EquipmentModelName { get; set; }

        [Display(Name = "Customer")]
        public string? CustomerName { get; set; }

        [Display(Name = "Contract")]
        public string? ContractNumber { get; set; }

        public IEnumerable<EquipmentServiceModel> Equipments{ get; set; } = Enumerable.Empty<EquipmentServiceModel>();

        public IEnumerable<string> AllМanifacturers { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllEquipmentsModels { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllCustomersNames { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllContractsNumbers { get; set; } = Enumerable.Empty<string>();

    }
}
