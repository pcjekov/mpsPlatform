using Microsoft.AspNetCore.Mvc;

namespace mpsPlatform.Controllers
{
	public class ManagementController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
