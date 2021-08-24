using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using alexaWineShop.Models;

namespace alexaWineShop.Data
{
    public class alexaWineShopContext : DbContext
    {
        public alexaWineShopContext (DbContextOptions<alexaWineShopContext> options)
            : base(options)
        {
        }

        public DbSet<alexaWineShop.Models.Workers> Workers { get; set; }

        public DbSet<alexaWineShop.Models.Buy> Buy { get; set; }

        public DbSet<alexaWineShop.Models.Sale> Sale { get; set; }

        public DbSet<alexaWineShop.Models.Attendence> Attendence { get; set; }

        public DbSet<alexaWineShop.Models.Login> Login { get; set; }
    }
}
