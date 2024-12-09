using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mobileShop.Server.Models
{
    public class PhoneCategoryAssociation
    {
        public int Id { get; set; }
        public Phone? Phone { get; set; }
        public PhoneCategory? Category { get; set; }
    }
}
