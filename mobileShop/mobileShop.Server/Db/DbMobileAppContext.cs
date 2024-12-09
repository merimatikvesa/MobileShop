using Microsoft.EntityFrameworkCore;
using mobileShop.Server.Models;

namespace mobileShop.Server.Db
{
    public class DbMobileAppContext : DbContext
    {
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Models.OperatingSystem> OperatingSystems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneAccessoryAssociation> PhoneAccessories { get; set; }
        public DbSet<PhoneCategory> PhoneCategories { get; set; }
        public DbSet<PhoneCategoryAssociation> PhoneCategoriesAssociation { get; set; }
        public DbSet<PhoneColor> PhoneColors { get; set; }
        public DbSet<PhoneColorAssociation> PhoneColorAssociations { get; set; }
        public DbSet<PhonePromotionAssociation> PhonePromotionAssociations { get; set; }
        public DbSet<PhoneSpecification> PhoneSpecificationAssociations { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ShipmentMethod> ShipmentMethods { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        public DbSet<StockSupply> StockSupply { get; set; }
        public DbSet<SupplierInformation> SupplierInformation { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Warranty> Warranties { get; set; }

        public DbMobileAppContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=mobileWebShop;Trusted_Connection=True");
        }
    }
}
