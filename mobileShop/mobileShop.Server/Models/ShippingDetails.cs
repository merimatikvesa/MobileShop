using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class ShippingDetails
    {
        public int Id { get; set; }
        public Orders? Order { get; set; }
        public string? ShippingAddress { get; set; }
        public DateTime ShippingDate { get; set; }
        public ShipmentMethod? ShipmentMethod { get; set; }
    }
}
