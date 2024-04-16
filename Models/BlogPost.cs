using System;
namespace SimpleBlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; } // Primary key
        public string Title { get; set; } // Title of the blog post
        public string Author { get; set; } // Author of the blog post
        public string Summary { get; set; } // Summary of the blog post
        public string Content { get; set; } // Full content of the blog post
        public DateTime PublicationDate { get; set; } // Date of publication
    }
}
