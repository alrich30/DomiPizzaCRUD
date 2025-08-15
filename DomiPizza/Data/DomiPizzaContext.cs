using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DomiPizza.Models.Entities;

namespace DomiPizza.Data
{
    public class DomiPizzaContext : DbContext
    {
        public DomiPizzaContext (DbContextOptions<DomiPizzaContext> options)
            : base(options)
        {
        }

        public DbSet<DomiPizza.Models.Entities.Pizza> Pizzas { get; set; } = default!;
        public DbSet<DomiPizza.Models.Entities.Customer> Customers { get; set; } = default!;
        public DbSet<DomiPizza.Models.Entities.Ingredient> Ingredients { get; set; } = default!;
        public DbSet<DomiPizza.Models.Entities.Order> Orders { get; set; } = default!;
        public DbSet<DomiPizza.Models.Entities.OrderDetail> OrderDetails { get; set; } = default!;
    }
}
