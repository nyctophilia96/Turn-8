using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;

namespace Turn8.ViewComponents
{
    public class Partial4ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context c = new Context();
            var selectedIds = new List<int> { 15, 21, 25 };
            var values = await Task.Run(() =>
            c.Blogs
            .Where(blog => selectedIds.Contains(blog.Id))
            .ToList()
            );
            return View("Partial4", values);
        }
    }
}