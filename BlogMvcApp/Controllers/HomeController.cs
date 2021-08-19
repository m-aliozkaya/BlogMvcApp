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
        // GET: Home
        public ActionResult Index()
        {
            BlogContext context = new BlogContext();

            List<Blog> blogs = context.Blogs.Where(b => b.IsActive == true).ToList();

            return View(blogs);
        }
    }
}