using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class StockInventory
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
