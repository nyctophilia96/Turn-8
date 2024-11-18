using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Blogs.OrderByDescending(x => x.Id).ToList();
            return View(values);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
