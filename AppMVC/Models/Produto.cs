using System.ComponentModel.DataAnnotations;
namespace AppMVC.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        [Range(0, 99999999.99)]
        public decimal Price { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
    }
}
