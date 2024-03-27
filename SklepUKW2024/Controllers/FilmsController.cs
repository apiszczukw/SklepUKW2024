using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepUKW2024.DAL;

namespace SklepUKW2024.Controllers
{
	public class FilmsController : Controller
	{
		FilmsContext db;

		public FilmsController(FilmsContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult FilmsList(string categoryName)
		{
			var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();

			var filmsFromCategory = category.Films.ToList();

			return View(filmsFromCategory);
		}

		public IActionResult Details(int filmId)
		{
			var film = db.Films.Find(filmId);
			var category = db.Categories.Find(film.CategoryId);

			return View(film);
		}
	}
}
