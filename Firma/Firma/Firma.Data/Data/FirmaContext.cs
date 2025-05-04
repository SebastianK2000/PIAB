using Firma.Data.Data.CMS;
using Firma.Data.Data.Sklep;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Data.Data
{
    public class FirmaContext : DbContext
    {
        public FirmaContext(DbContextOptions<FirmaContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; } = default!;
        public DbSet<Strona> Strona { get; set; } = default!;
        public DbSet<Kind> Kind { get; set; } = default!;
        public DbSet<Orders> Orders { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Reports> Reports { get; set; } = default!;
        public DbSet<Support> Support { get; set; } = default!;
        public DbSet<Users> Users { get; set; } = default!;
        public DbSet<Privacy> Privacy { get; set; } = default!;
        public object Strony { get; set; }
    }
}