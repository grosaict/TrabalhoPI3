using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Margille.Models
{
    public class MargilleContext : DbContext
    {
        public MargilleContext (DbContextOptions<MargilleContext> options)
            : base(options)
        {
        }

        public DbSet<Margille.Models.Client> Client { get; set; }
        public DbSet<Margille.Models.Ingredient> Ingredient { get; set; }
        public DbSet<Margille.Models.Order> Order { get; set; }
        public DbSet<Margille.Models.Pizza> Pizza { get; set; }
        public DbSet<Margille.Models.PizzaIngredient> PizzaIngredient { get; set; }
        public DbSet<Margille.Models.Product> Product { get; set; }
        public DbSet<Margille.Models.ProductOrder> ProductOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Para ProductOrders
            modelBuilder.Entity<ProductOrder>()
                .HasKey(po => new { po.ProductId, po.OrderId });
            modelBuilder.Entity<ProductOrder>()
                .HasOne(po => po.Product)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(po => po.ProductId);
            modelBuilder.Entity<ProductOrder>()
                .HasOne(po => po.Order)
                .WithMany(o => o.ProductOrders)
                .HasForeignKey(po => po.OrderId);

            // Para PizzaIngredients
            modelBuilder.Entity<PizzaIngredient>()
                .HasKey(pi => new { pi.PizzaId, pi.IngredientId });
            modelBuilder.Entity<PizzaIngredient>()
                .HasOne(pi => pi.Pizza)
                .WithMany(b => b.PizzaIngredients)
                .HasForeignKey(pi => pi.PizzaId);
            modelBuilder.Entity<PizzaIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(c => c.PizzaIngredients)
                .HasForeignKey(pi => pi.IngredientId);
        }
    }
}
