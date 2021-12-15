using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementOrder.Models;

namespace RestaurantManagementOrder.Data
{
    public class RestaurantManagementOrderContext : DbContext
    {
        public RestaurantManagementOrderContext (DbContextOptions<RestaurantManagementOrderContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.MenuItemId, oi.OrderId });
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Cook> Cook { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Waiter> Waiter { get; set; }
    }
}
