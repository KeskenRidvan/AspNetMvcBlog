using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
	public class Navbar : ViewComponent
	{
		//private readonly AppDbContext _context;

		//public Navbar(AppDbContext context)
		//{
		//	_context = context;
		//}

		//public async Task<IViewComponentResult> InvokeAsync()
		//{
		//	NavbarViewModel viewModel = new NavbarViewModel();

		//	viewModel.Categories = await _context.Categories.ToListAsync();
		//	viewModel.Pages = await _context.Pages.ToListAsync();

		//	return View(viewModel);
		//}
	}
}
