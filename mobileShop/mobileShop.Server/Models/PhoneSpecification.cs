using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class PhoneSpecification
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public string? Details { get; set; }
    }
}
