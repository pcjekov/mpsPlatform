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
                                                            string? manufacturer,
                                                            string? equipmentModel,
                                                            string? customerName,
                                                            string? contractNumber,
                                                            DateTime? dateOfCounter)
                                                            
        {
            var result = new EquipmentFilterModel();

            var equipments = repo.AllReadonly<SerialNumber>();

            if (string.IsNullOrEmpty(manufacturer) == false)
            {
                equipments = equipments
                    .Where(x => x.ЕquipmentModel.Manufacturer.Name == manufacturer);
            }

            if (string.IsNullOrEmpty(equipmentModel) == false)
            {
                equipments = equipments
                             .Where(x => x.ЕquipmentModel.Name == equipmentModel);
            }

            if (string.IsNullOrEmpty(customerName) == false)
            {
                equipments = equipments
                             .Where(x => x.Contract.Customer.Name == customerName);
            }

            if (string.IsNullOrEmpty(contractNumber) == false)
            {
                equipments = equipments
                             .Where(x => x.Contract.ContractNumber == contractNumber);
            }

            if (dateOfCounter != null)
            {
                result.Equipments = await equipments
                    .Select(x => new EquipmentServiceModel()
                    {
                        Id = x.Id,
                        ManufacturerName = x.ЕquipmentModel.Manufacturer.Name,
                        EquipmentModelName = x.ЕquipmentModel.Name,
                        CustomerName = x.Contract.Customer.Name,
                        ContractNumber = x.Contract.ContractNumber,
                        LocationName = x.Location.EquimpentLocation,
                        SerialNumber = x.ЕquipmentSerialNumber,
                        Counter = x.Counters
                                   .Select(y => y.MonochromeA4)
                                   .OrderByDescending(y => y)
                                   .FirstOrDefault(),
                        Date = x.Counters
                                .Select(y => y.DateOfCounter)
                                .OrderByDescending(y => y)
                                .First()
                    })
                    .ToListAsync();
            }
            else
            {
                result.Equipments = await equipments
                    .Select(x => new EquipmentServiceModel()
                    {
                        Id = x.Id,
                        ManufacturerName = x.ЕquipmentModel.Manufacturer.Name,
                        EquipmentModelName = x.ЕquipmentModel.Name,
                        CustomerName = x.Contract.Customer.Name,
                        ContractNumber = x.Contract.ContractNumber,
                        LocationName = x.Location.EquimpentLocation,
                        SerialNumber = x.ЕquipmentSerialNumber,
                        Counter = x.Counters
                                   .Select(y => y.MonochromeA4)
                                   .OrderByDescending(y => y)
                                   .First(),
                        Date = x.Counters
                                .Select(y => y.DateOfCounter)
                                .OrderByDescending(y => y)
                                .First()
                    })
                    .ToListAsync();
            }

            return result.Equipments;
            
        }

        public async Task<IEnumerable<string>> AllManufacturersNames()
        {
            var allManufacturersNames = new List<string>();
            var manufacturers = repo.AllReadonly<Manufacturer>();

            allManufacturersNames = await manufacturers
                                          .Select(x => x.Name)
                                          .Distinct()
                                          .OrderBy(x => x)
                                          .ToListAsync();

            return allManufacturersNames;
        }

        public async Task<IEnumerable<string>> AllEquipmentsModelsNames()
        {
            var allEquipmentsModels = new List<string>();
            var equipmentsModels = repo.AllReadonly<ЕquipmentModel>();

            allEquipmentsModels = await equipmentsModels
                                          .OrderBy(x => x.Manufacturer.Name)
                                          .ThenBy(x => x.Name)
                                          .Select(x => x.Name)
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

        public async Task<IEnumerable<DateTime>> AllDatesOfCounters()
        {
            var allDatesOfCounters = new List<DateTime>();
            var dates = repo.AllReadonly<Counter>();

            allDatesOfCounters = await dates
                                          .Select(x => x.DateOfCounter)
                                          .Distinct()
                                          .OrderBy(x => x)
                                          .ToListAsync();

            return allDatesOfCounters;
        }
    }
}
