using dotnetblog.Models;
using System.ComponentModel.DataAnnotations;

namespace dotnetblog.ViewModel
{
    public class PostsVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Body field is required.")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // You can include any additional properties or data annotations needed for your view
    }

}
