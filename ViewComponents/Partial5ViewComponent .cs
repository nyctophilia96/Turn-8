using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.ViewComponents
{
    public class Partial5ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context c = new Context();
            var selectedIds = new List<int> { 11, 14, 23 };
            var values = await Task.Run(() =>
            c.Blogs
            .Where(blog => selectedIds.Contains(blog.Id))
            .ToList()
            );
            return View("Partial5", values);
        }
    }
}