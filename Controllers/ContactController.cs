using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.Controllers
{
    public class ContactController : Controller
    {
		Context c = new Context();

		[HttpGet]
		public IActionResult Index()
        {
			var addresses = c.Addresses.ToList();
			return View(addresses);
		}

		[HttpPost]
		public IActionResult Index(Contact i)
		{
			c.Contacts.Add(i);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}

