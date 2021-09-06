using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {

            var blogs = context.Blogs
                .Where(b => b.IsActive == true && b.IsValid == true)
                .Select(b => new BlogModel()
                {
                    Id = b.Id,
                    Title = b.Title.Length > 100 ? b.Title.Substring(0, 100) + "..." : b.Title,
                    Description = b.Description,
                    CreatedDate = b.CreatedDate,
                    IsActive = b.IsActive,
                    IsValid = b.IsValid,
                    Image = b.Image
                });



            return View(blogs.ToList());
        }
    }
}