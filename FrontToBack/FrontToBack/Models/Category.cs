using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Models
{
    public class Category :BaseEntity
    {
        [Required(ErrorMessage ="YETER YETER ERRAR !!!!!")]
        [MaxLength(30,ErrorMessage = "ERORR!!!!!!!!!!!!!")]
        public string? Name { get; set; }

        public List<Product> ?Products { get; set; }
    }
}
