using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class SupplierInformation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ContactPerson { get; set; }
        public string? SupplierAddress { get; set; }
    }
}
