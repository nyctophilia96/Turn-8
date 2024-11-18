using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.ViewComponents
{
    public class Partial2ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context c = new Context();
            var values = await Task.Run(() => c.Blogs.Where(x => x.Id == 2).ToList());
            return View("Partial2", values); 
        }
    }
}