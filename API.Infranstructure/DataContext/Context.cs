using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Core.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Infranstructure.DataContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)    // OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=94.73.146.3;database=u0625128_Core;User = u0625128_user01;Password =XMxe96O6YKwc16E");
            optionsBuilder.UseSqlServer("server=DESKTOP-DR83AEK\\SQLEXPRESS;database=StoreContext2;integrated security=true");

        }
        public DbSet<Product>? Products { get; set; }

    }
}

