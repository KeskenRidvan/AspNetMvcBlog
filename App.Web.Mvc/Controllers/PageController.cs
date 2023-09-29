using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class PageController : Controller
	{
		[Route("page/title-{id}")]
		public IActionResult Detail(int id)
		{
			return View();
		}
	}
}
