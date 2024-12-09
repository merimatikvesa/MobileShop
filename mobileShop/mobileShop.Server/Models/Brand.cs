using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string? BrandName { get; set; }
    }
}
