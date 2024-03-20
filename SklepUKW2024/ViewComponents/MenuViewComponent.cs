using Microsoft.AspNetCore.Mvc;
using SklepUKW2024.DAL;

namespace SklepUKW2024.ViewComponents
{
	public class MenuViewComponent : ViewComponent
	{
		FilmsContext db;

		public MenuViewComponent(FilmsContext db)
		{
			this.db = db;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = db.Categories.ToList();

			return await Task.FromResult((IViewComponentResult)View("_Menu", categories));
		}
	}
}
