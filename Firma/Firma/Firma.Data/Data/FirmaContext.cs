using Firma.Data.Data.CMS;
using Firma.Data.Data.Sklep;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Firma.Data.Data
{
    public class FirmaContext : IdentityDbContext<IdentityUser>
    {
        public FirmaContext(DbContextOptions<FirmaContext> options)
            : base(options) { }

        // CMS
        public DbSet<News> News { get; set; } = default!;
        public DbSet<Strona> Strona { get; set; } = default!;
        public DbSet<ContentText> ContentText { get; set; } = default!;
        public DbSet<Privacy> Privacy { get; set; } = default!;

        // Sklep
        public DbSet<Kind> Kind { get; set; } = default!;
        public DbSet<Orders> Orders { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Reports> Reports { get; set; } = default!;
        public DbSet<Support> Support { get; set; } = default!;

        public DbSet<Users> Users { get; set; } = default!;
    }
}