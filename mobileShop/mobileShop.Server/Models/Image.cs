using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Phone? Phone { get; set; }
    }
}
