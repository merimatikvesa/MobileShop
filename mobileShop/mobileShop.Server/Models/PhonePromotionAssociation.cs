using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class PhonePromotionAssociation
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public Promotion? Promotion { get; set; }
    }
}
