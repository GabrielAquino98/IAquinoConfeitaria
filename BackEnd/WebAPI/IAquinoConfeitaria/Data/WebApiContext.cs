using IAquinoConfeitaria.Models;
using Microsoft.EntityFrameworkCore;

namespace IAquinoConfeitaria.Data
{
    public class WebApiContext : DbContext
    {
        public DbSet<ClientModel> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Data Source=iaquinoconf.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
