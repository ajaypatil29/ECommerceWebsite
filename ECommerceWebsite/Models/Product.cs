using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebsite.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Display(Name = "Upload Image")]
        public string? ImageUrl { get; set; }
        [ForeignKey("CatId")]
        [Display(Name ="Catagery Name")]
        public int CatId { get; set; }
        [ScaffoldColumn(false)]
        [NotMapped]
        public string? CatName { get; set; }

        public int Discount { get; set; }
        [Required]
        [MaxLength(300)]
        public string? Discription { get; set; }

        public int Stock { get; set; }

    }
}
