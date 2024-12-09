using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public Orders? Order { get; set; }
        public string? PaymentType { get; set; }
        public string? PaymentStatus { get; set; }
    }
}
