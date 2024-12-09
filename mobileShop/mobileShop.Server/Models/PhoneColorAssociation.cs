using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace mobileShop.Server.Models
{
    public class PhoneColorAssociation
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public PhoneColor? Color{ get; set; }
    }
}
