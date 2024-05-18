using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetblog.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Name")]
        public int DisplayOrder {  get; set; }
        public ICollection<Post> Posts { get; set; }
    }
    }

