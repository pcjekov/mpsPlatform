using Microsoft.EntityFrameworkCore;
using mpsPlatform.Core.Contracts;
using mpsPlatform.Core.Models;
using mpsPlatform.Infrastructure.Data.Common;
using mpsPlatform.Infrastructure.Data.Models;
using mpsPlatform.Models;

namespace mpsPlatform.Core.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IRepository repo;

        public EquipmentService(IRepository _repo)
        {
            repo = _repo;
        }

       

        public async Task<IEnumerable<EquipmentServiceModel>> GetAllAsync(
                                                            string? manifacturer,
                                                            string? equipmentModel,
                                                            string? customerName,
                                                            string? contractNumber)
        {
            var result = new EquipmentFilterModel();
            var equipments = repo.AllReadonly<SerialNumber>();

            if (string.IsNullOrEmpty(manifacturer) == false)
            {
                equipments = equipments.
                             Where(x => x.ЕquipmentModel.Мanifacturer.Name == manifacturer);
            }

            if (string.IsNullOrEmpty(customerName) == false)
            {
                equipments = equipments.
                             Where(x => x.Contract.Customer.Name == customerName);
            }

            if (string.IsNullOrEmpty(contractNumber) == false)
            {
                equipments = equipments.
                             Where(x => x.Contract.ContractNumber == contractNumber);
            }

            result.Equipments = await equipments.
                Select(x => new EquipmentServiceModel()
                {
                    Id = x.Id,
                    ManifacturerName = x.ЕquipmentModel.Мanifacturer.Name,
                    EquipmentModelName = x.ЕquipmentModel.Name,
                    CustomerName = x.Contract.Customer.Name,
                    ContractNumber = x.Contract.ContractNumber,
                    LocationName = x.Location.EquimpentLocation,
                    SerialNumber = x.ЕquipmentSerialNumber,
                    Date = "empty",
                    CurrentCounter = x.CountersMonochromeA4
                                      .OrderBy(y => y.Id)
                                      .Last().CurrentCounter
                })
                .ToListAsync();
            
            return result.Equipments;
            
        }

        public async Task<IEnumerable<string>> AllМanifacturersNames()
        {
            var allМanifacturersNames = new List<string>();
            var manifacturers = repo.AllReadonly<Мanifacturer>();

            allМanifacturersNames = await manifacturers
                                          .Select(x => x.Name)
                                          .Distinct()
                                          .OrderBy(x => x)
                                          .ToListAsync();
                                          

            return allМanifacturersNames;
        }

        public async Task<IEnumerable<string>> AllEquipmentsModelsNames()
        {
            var allEquipmentsModels = new List<string>();
            var equipmentsModels = repo.AllReadonly<ЕquipmentModel>();

            allEquipmentsModels = await equipmentsModels
                                          .Select(x => x.Name)
                                          .Distinct()
                                          .OrderBy(x => x)
                                          .ToListAsync();

            return allEquipmentsModels;
        }

        public async Task<IEnumerable<string>> AllCustomersNames()
        {
            var allCustomersName = new List<string>();
            var customers = repo.AllReadonly<Customer>();

            allCustomersName = await customers
                                          .Select(x => x.Name)
                                          .Distinct()
                                          .OrderBy(x => x)
                                          .ToListAsync();

            return allCustomersName;
        }

        public async Task<IEnumerable<string>> AllContractsNumbers()
        {
            var allContractsNumbers = new List<string>();
            var contracts = repo.AllReadonly<Contract>();

            allContractsNumbers = await contracts
                                          .Select(x => x.ContractNumber)
                                          .Distinct()
                                          .OrderBy(x => x)
                                          .ToListAsync();

            return allContractsNumbers;
        }

        
    }
}
