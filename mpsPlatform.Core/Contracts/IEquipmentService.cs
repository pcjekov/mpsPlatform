using mpsPlatform.Models;

namespace mpsPlatform.Core.Contracts
{
    public interface IEquipmentService
    {
        Task<IEnumerable<EquipmentServiceModel>> GetAllAsync(
                                                string? manufacturer,
                                                string? equipmentModel,
                                                string? customerName,
                                                string? contractNumber,
                                                DateTime? dateOfCounter);

        Task<IEnumerable<string>> AllManufacturersNames();
        Task<IEnumerable<string>> AllEquipmentsModelsNames();
        Task<IEnumerable<string>> AllCustomersNames();
        Task<IEnumerable<string>> AllContractsNumbers();
        Task<IEnumerable<DateTime>> AllDatesOfCounters();
    }
}
