using Microsoft.AspNetCore.Mvc;
using Turn8.Models.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Turn8.Controllers
{
    [Authorize(AuthenticationSchemes = "AdminAuthScheme")]
    public class AdminController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetBlog(int id)
        {
            var b = c.Blogs.Find(id);
            return View("GetBlog", b);
        }

        public IActionResult UpdateBlog(Blog b)
        {
            var blog = c.Blogs.Find(b.Id);
            blog.Description = b.Description;
            blog.Title = b.Title;
            blog.BlogImage = b.BlogImage;
            blog.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CommentList()
        {
            var values = c.Comments.Include(c => c.Blog).ToList();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = c.Comments.Find(id);
            c.Comments.Remove(comment);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public IActionResult GetComment(int id)
        {
            var comment = c.Comments.Find(id);
            return View("GetComment", comment);
        }

        public IActionResult UpdateComment(Comment com)
        {
            var comment = c.Comments.Find(com.Id);
            comment.Name = com.Name;
            comment.Mail = com.Mail;
            comment._Comment = com._Comment;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public IActionResult ContactList()
        {
            var values = c.Contacts.ToList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var contact = c.Contacts.Find(id);
            c.Contacts.Remove(contact);
            c.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
