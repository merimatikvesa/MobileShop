using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class ProductRating
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public float AverageRating { get; set; }
        public int NumberOfRatings { get; set; }
    }
}
