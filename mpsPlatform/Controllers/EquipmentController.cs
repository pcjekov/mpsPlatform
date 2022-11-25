using Microsoft.AspNetCore.Mvc;
using mpsPlatform.Core.Contracts;
using mpsPlatform.Core.Models;
using mpsPlatform.Infrastructure.Data.Models;
using System.Diagnostics;

namespace mpsPlatform.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentService equipmentService;

        public EquipmentController(IEquipmentService _equipmentService)
        {
            equipmentService = _equipmentService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]EquipmentFilterModel filters)
        {
            var result = await equipmentService.GetAllAsync(
                                                filters.ManifacturerName,
                                                filters.EquipmentModelName,
                                                filters.CustomerName,
                                                filters.ContractNumber);

            filters.AllМanifacturers = await equipmentService.AllМanifacturersNames();
            filters.AllEquipmentsModels = await equipmentService.AllEquipmentsModelsNames();
            filters.AllCustomersNames = await equipmentService.AllCustomersNames();
            filters.AllContractsNumbers = await equipmentService.AllContractsNumbers();

            filters.Equipments = result;



            return View(filters);
        }
    }
}
