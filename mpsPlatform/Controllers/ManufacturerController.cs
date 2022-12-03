using Microsoft.AspNetCore.Mvc;
using mpsPlatform.Core.Constants;
using mpsPlatform.Core.Contracts;
using mpsPlatform.Core.Models;

namespace mpsPlatform.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerService manufacturerService;

        public ManufacturerController(IManufacturerService _manufacturerService)
        {
            manufacturerService = _manufacturerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await manufacturerService.GetAllAsync();

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> AllManufacturers()
        {
            var result = await manufacturerService.GetAllAsync();

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> AddManufacturer()
        {
            var model = new ManufacturerModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddManufacturer(ManufacturerModel model)
        {
            //TODO: проерка дали е админ

            if (await manufacturerService.ExistManufacturer(model.Name))
            {
                ModelState.AddModelError(model.Name, MessageConstant.ManufacturerExistMassage);
                TempData[MessageConstant.ErrorMessage] = MessageConstant.ManufacturerExistMassage;
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await manufacturerService.AddManufacturer(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
