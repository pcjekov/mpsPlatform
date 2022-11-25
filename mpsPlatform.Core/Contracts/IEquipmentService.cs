using mpsPlatform.Models;

namespace mpsPlatform.Core.Contracts
{
    public interface IEquipmentService
    {
        Task<IEnumerable<EquipmentServiceModel>> GetAllAsync(
                                                string? manifacturer,
                                                string? equipmentModel,
                                                string? customerName,
                                                string? contractNumber);

        Task<IEnumerable<string>> AllМanifacturersNames();
        Task<IEnumerable<string>> AllEquipmentsModelsNames();
        Task<IEnumerable<string>> AllCustomersNames();
        Task<IEnumerable<string>> AllContractsNumbers();
    }
}
