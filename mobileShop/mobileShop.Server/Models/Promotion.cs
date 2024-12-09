using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Discount { get; set; }
    }
}
