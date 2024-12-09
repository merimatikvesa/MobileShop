using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class ShipmentMethod
    {
        public int Id { get; set; }
        public string? ShipmentCompany { get; set; }
        public float ShipmentPrice { get; set; }
    }
}
