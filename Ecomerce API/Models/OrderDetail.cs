using System.ComponentModel.DataAnnotations;

namespace Ecomerce_API.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public long OrderMasterID { get; set; }
        public OrderMaster? OrderMaster { get; set; }

        public int ClothingID { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }

    }
}
