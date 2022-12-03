using mpsPlatform.Core.Models;
using mpsPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpsPlatform.Core.Contracts
{
	public interface IManufacturerService
	{
        Task <ManufacturerListModel> GetAllAsync();

        Task AddManufacturer(ManufacturerModel model);

        Task<bool> ExistManufacturer(string name);

        Task<bool> ExistManufacturerIsDeleted(string name);

        Task RestoreDeletedManufacturer(string name);
    }
}
