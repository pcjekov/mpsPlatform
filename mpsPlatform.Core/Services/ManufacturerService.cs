using Microsoft.EntityFrameworkCore;
using mpsPlatform.Core.Contracts;
using mpsPlatform.Core.Models;
using mpsPlatform.Infrastructure.Data.Common;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Core.Services
{
    public class ManufacturerService : IManufacturerService
	{
        private readonly IRepository repo;

        public ManufacturerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<ManufacturerListModel> GetAllAsync()
		{
            var result = new ManufacturerListModel();

            var manufacturers = repo.AllReadonly<Manufacturer>().Where(x => !x.IsDeleted);

            result.Manufacturers = await manufacturers
                                   .Select(x => new ManufacturerModel()
                                   {
                                       Id = x.Id,
                                       Name = x.Name
                                   })
                                   .OrderBy(x => x.Name)
                                   .ToListAsync();
            return result;
        }

        public async Task AddManufacturer(ManufacturerModel model)
        {
            var manufacturer = new Manufacturer()
            {
                Name = model.Name,
                ЕquipmentModels = new List<ЕquipmentModel>()
            };

            await repo.AddAsync(manufacturer);
            await repo.SaveChangesAsync();
        }

        public async Task RestoreDeletedManufacturer(string name)
        {
            var matched = await repo.All<Manufacturer>().FirstAsync(x => x.IsDeleted && x.Name == name);

            matched.IsDeleted = false;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistManufacturer(string name)
        {
            return await repo.AllReadonly<Manufacturer>().AnyAsync(x => !x.IsDeleted && x.Name == name);
        }

        public async Task<bool> ExistManufacturerIsDeleted(string name)
        {
            return await repo.AllReadonly<Manufacturer>().AnyAsync(x => x.IsDeleted && x.Name == name);
        }

    }
}
