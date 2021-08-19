using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{Name = "C#"},
                new Category{Name = "Asp .Net Mvc"},
                new Category{Name = "Asp .Net Web Api"},
                new Category{Name = "Asp .Net Web Forms"},
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog
                {
                    Title = "C# Delegates", Description = "C# Delegates Description",
                    CreatedDate = DateTime.Now.AddDays(-10 ), IsActive = true, IsValid = true,
                    Content = "C# Delegates Content", Image = "1.jpg", CategoryId = 1
                },
                new Blog
                {
                    Title = "Asp .Net Mvc or ..?", Description = "Asp .Net Mvc or ..? Description",
                    CreatedDate = DateTime.Now.AddDays(-20 ), IsActive = true, IsValid = true,
                    Content = "Asp .Net Mvc or ..? Content", Image = "2.jpg", CategoryId = 2
                },
                new Blog
                {
                    Title = "2Asp .Net Mvc or ..?", Description = "2Asp .Net Mvc or ..? Description",
                    CreatedDate = DateTime.Now.AddDays(-20 ), IsActive = false, IsValid = true,
                    Content = "2Asp .Net Mvc or ..? Content", Image = "2.jpg", CategoryId = 2
                },
                new Blog
                {
                    Title = "3Asp .Net Mvc or ..?", Description = "3Asp .Net Mvc or ..? Description",
                    CreatedDate = DateTime.Now.AddDays(-20 ), IsActive = true, IsValid = false,
                    Content = "3Asp .Net Mvc or ..? Content", Image = "2.jpg", CategoryId = 2
                },
                new Blog
                {
                    Title = "Asp .Net Web Api or ..?", Description = "Asp .Net Web Api or ..? Description",
                    CreatedDate = DateTime.Now.AddDays(-30 ), IsActive = true, IsValid = true,
                    Content = "Asp .Net Web Api or ..? Content", Image = "3.jpg", CategoryId = 3
                },
                new Blog
                {
                    Title = "Asp .Net Web Forms or ..?", Description = "Asp .Net Web Forms or ..? Description",
                    CreatedDate = DateTime.Now.AddDays(-40 ), IsActive = true, IsValid = true,
                    Content = "Asp .Net Web Forms or ..? Content", Image = "4.jpg", CategoryId = 4
                }
            };

            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}