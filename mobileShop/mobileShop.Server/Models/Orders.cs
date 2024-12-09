using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public Users? User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
    }
}
