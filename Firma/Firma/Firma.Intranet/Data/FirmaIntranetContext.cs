using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Firma.Intranet.Models.CMS;
using Firma.Intranet.Models.Shop;

namespace Firma.Intranet.Data
{
    public class FirmaIntranetContext : DbContext
    {
        public FirmaIntranetContext (DbContextOptions<FirmaIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Firma.Intranet.Models.CMS.News> News { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.CMS.Strona> Strona { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.Shop.Kind> Kind { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.Shop.Orders> Orders { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.Shop.Product> Product { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.Shop.Reports> Reports { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.Shop.Support> Support { get; set; } = default!;
        public DbSet<Firma.Intranet.Models.Shop.Users> Users { get; set; } = default!;
    }
}
