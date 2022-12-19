using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace FoodOrderApp.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }

        [Required]
        [DisplayName("Product Price")]
        public int ProductPrice { get; set;}

        [Required]
        [DisplayName("Product Image")]
        public string ProductImage { get; set; }

    }
}
