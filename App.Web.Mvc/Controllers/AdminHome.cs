using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class AdminHome : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
