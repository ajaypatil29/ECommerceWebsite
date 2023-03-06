
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebsite.Models
{
    [Table("ProuductCat")]
    public class ProductCat
    {
        [Key]
        [ScaffoldColumn(false)]

        public int CatId { get; set; }
        [Required]
        public string? CatName { get; set; }    
    }
}
