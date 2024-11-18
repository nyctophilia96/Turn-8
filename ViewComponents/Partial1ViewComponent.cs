using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.ViewComponents
{
    public class Partial1ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context c = new Context();
            var values = await Task.Run(() => c.Blogs.OrderByDescending(x => x.Id).Take(2).ToList());
            return View("Partial1", values);
        }
    }
}