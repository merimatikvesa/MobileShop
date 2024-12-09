using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public Brand? Brand { get; set; }
        public float Price { get; set; }
        public int StockAvailability { get; set; }
        public Warranty? Warranty { get; set; }
        public OperatingSystem? OperatingSystem { get; set; }
        public SupplierInformation? Supplier { get; set; }
    }
}
