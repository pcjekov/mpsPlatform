using mpsPlatform.Models;

namespace mpsPlatform.Core.Models
{
    public class EquipmentFilterModel
    {
        public string? ManifacturerName { get; set; }

        public string? EquipmentModelName { get; set; }

        public string? CustomerName { get; set; }

        public string? ContractNumber { get; set; }

        public IEnumerable<EquipmentServiceModel> Equipments{ get; set; } = Enumerable.Empty<EquipmentServiceModel>();

        public IEnumerable<string> AllМanifacturers { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllEquipmentsModels { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllCustomersNames { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> AllContractsNumbers { get; set; } = Enumerable.Empty<string>();

    }
}
