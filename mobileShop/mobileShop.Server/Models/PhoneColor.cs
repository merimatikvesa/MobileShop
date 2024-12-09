using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class PhoneColor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
