using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomerce_API.Models
{
    public class Product
    {
        [Key]
        public int ClothingID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string ClothingName { get; set; } = default!;

        [Column(TypeName = "nvarchar (100)")]
        public string ClothingDescription { get; set; } = default!;

        public decimal ClothingPrice { get; set; }
    }
}
