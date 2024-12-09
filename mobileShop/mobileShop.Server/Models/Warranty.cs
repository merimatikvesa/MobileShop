using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Warranty
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public int Duration { get; set; }
    }
}
