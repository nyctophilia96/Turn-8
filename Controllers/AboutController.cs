using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.Controllers
{
	public class AboutController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var values = c.Abouts.ToList();
			return View(values);
		}
	}
}