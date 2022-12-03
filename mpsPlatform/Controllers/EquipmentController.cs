using Microsoft.AspNetCore.Mvc;
using mpsPlatform.Core.Contracts;
using mpsPlatform.Core.Models;

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
                                                filters.ManufacturerName,
                                                filters.EquipmentModelName,
                                                filters.CustomerName,
                                                filters.ContractNumber,
                                                filters.DateOfCounter);

            filters.AllManufacturers = await equipmentService.AllManufacturersNames();
            filters.AllEquipmentsModels = await equipmentService.AllEquipmentsModelsNames();
            filters.AllCustomersNames = await equipmentService.AllCustomersNames();
            filters.AllContractsNumbers = await equipmentService.AllContractsNumbers();
            filters.AllDatesOfCounters = await equipmentService.AllDatesOfCounters();

            filters.Equipments = result;

            return View(filters);
        }
    }
}
