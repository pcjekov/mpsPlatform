using mpsPlatform.Models;
using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Core.Models
{
    public class EquipmentFilterModel
    {
        [Display(Name = "Manufacturer")]
        public string? ManufacturerName { get; set; }

        [Display(Name = "Model")]
        public string? EquipmentModelName { get; set; }

        [Display(Name = "Customer")]
        public string? CustomerName { get; set; }

        [Display(Name = "Contract")]
        public string? ContractNumber { get; set; }

        [Display(Name = "Date")]
        public DateTime? DateOfCounter { get; set; }

        public IEnumerable<EquipmentServiceModel> Equipments{ get; set; } = Enumerable.Empty<EquipmentServiceModel>();

        public IEnumerable<string> AllManufacturers { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllEquipmentsModels { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllCustomersNames { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllContractsNumbers { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<DateTime> AllDatesOfCounters { get; set; } = Enumerable.Empty<DateTime>();

    }
}
