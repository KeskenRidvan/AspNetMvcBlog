using App.Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class AuthController : Controller
	{

		private readonly IUserService _userService;

		public AuthController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(User model)
		{
			if (model == null)
				return View(model);

			if (!ModelState.IsValid)
				return View(model);

			_context.Add(model);
			_context.SaveChanges();

			return RedirectToAction(controllerName: "Home", actionName: "Index");
		}

		public IActionResult Login(string redirectUrl)
		{
			return View();
		}
		public IActionResult ForgotPassword()
		{
			return View();
		}
	}
}
