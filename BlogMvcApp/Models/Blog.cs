using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsValid { get; set; }
        public bool IsActive { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}