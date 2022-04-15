using API.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Data.DataContext
{
    public class StoreContext : DbContext // Db Context Sınıfından Almak zorunda
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=94.73.146.3;database=u0625128_Core;User = u0625128_user01;Password =XMxe96O6YKwc16E");
            optionsBuilder.UseSqlServer("server=DESKTOP-DR83AEK\\SQLEXPRESS;database=StoreContext;integrated security=true");

        }
        public DbSet<Product> Products { get; set; }

    }
}
