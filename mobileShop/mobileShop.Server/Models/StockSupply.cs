using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class StockSupply
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public StockInventory? Inventory { get; set; }
        public int Quantity { get; set; }
        public DateTime StockDate { get; set; }
    }
}
