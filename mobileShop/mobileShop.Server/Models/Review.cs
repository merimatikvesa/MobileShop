using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public Users? User { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
    }
}
