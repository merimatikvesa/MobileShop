using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class PhoneAccessoryAssociation
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public Accessory? Accessory { get; set; }
    }
}
