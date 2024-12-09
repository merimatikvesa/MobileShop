using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Favorites
    {
        public int Id { get; set; }
        public Users? User { get; set; }
        public Phone? Phone { get; set; }
    }
}
