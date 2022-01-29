using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomerce_API.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterID { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string OrderNumber { get; set; } = default!;

        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = default!;

        [Column(TypeName = "nvarchar(15)")]
        public string PayMethod { get; set; } = default!;

        public decimal OveralTotal { get; set; }
    }
}
