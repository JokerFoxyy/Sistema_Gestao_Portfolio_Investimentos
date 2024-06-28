using SistemaGestaoPortfolioInvestimentos.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace SistemaGestaoPortfolioInvestimentos.Data
{
    public class DataBaseContext : DbContext
    {


        public DbSet<Product> Products { get; set; }
        public DbSet<Investment> Investments { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }



    }
}
