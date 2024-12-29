using IAquinoConfeitaria.Models;
using Microsoft.EntityFrameworkCore;

namespace IAquinoConfeitaria.Data
{
    public class WebApiContext : DbContext
    {
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<CouponModel> Coupons { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<IngredientModel> Ingredients { get; set; }
        public DbSet<BuyModel> Buys { get; set; }
        public DbSet<ItenBuyModel> Itens { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Data Source=iaquinoconf.sqlite");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
