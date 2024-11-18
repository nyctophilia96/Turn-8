using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turn8.Models.Classes;
using X.PagedList.Extensions;

namespace Turn8.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogComments bc = new BlogComments();

        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            bc.Value1 = c.Blogs.ToPagedList(page, pageSize);
            bc.Value2 = c.Comments.Include(c => c.Blog)
                .OrderByDescending(x => x.Id)
                .Take(10);
            bc.Value3 = c.Blogs.OrderByDescending(x => x.Id).Take(10);
            return View(bc);
        }

        [HttpGet]
        public IActionResult BlogDetail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Blog");
            }

            ViewBag.Id = id;
            bc.Value1 = c.Blogs.Where(x => x.Id == id).ToList();
            bc.Value2 = c.Comments.Where(x => x.BlogId == id).ToList();
            bc.Value3 = c.Blogs.OrderByDescending(x => x.Id).Take(10);
            bc.Value4 = c.Comments.Include(c => c.Blog)
                .OrderByDescending(x => x.Id)
                .Take(10);
            return View(bc);
        }

        [HttpPost]
        public IActionResult BlogDetail(Comment p)
        {
            c.Comments.Add(p);
            c.SaveChanges();
            return RedirectToAction("BlogDetail", new { id = p.BlogId });
        }
    }
}
