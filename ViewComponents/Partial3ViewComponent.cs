using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.ViewComponents
{
    public class Partial3ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context c = new Context();
            var selectedIds = new List<int> { 23, 38, 26, 11, 25, 16, 8, 14, 13, 31 };
            var values = await Task.Run(() =>
            c.Blogs
            .Where(blog => selectedIds.Contains(blog.Id))
            .AsEnumerable()
            .OrderBy(blog => selectedIds.IndexOf(blog.Id))
            .ToList()
            );
            return View("Partial3", values);
        }
    }
}