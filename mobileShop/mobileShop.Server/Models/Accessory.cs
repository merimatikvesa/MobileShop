using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
    }
}
