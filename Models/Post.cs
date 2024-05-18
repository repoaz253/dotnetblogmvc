using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetblog.Models
{
    public class Post
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public string Body { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }= DateTime.Now;

      


    }
}
