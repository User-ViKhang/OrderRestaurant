using Microsoft.EntityFrameworkCore;
using RestaurentAPI.Data.Entities;

namespace RestaurentAPI.Data
{
    public class RestautantDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public RestautantDbContext(DbContextOptions<RestautantDbContext> options)
        : base(options)
        {
        }

        public RestautantDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasKey(p => p.Id);
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<Item>().HasKey(o => o.Id);
            modelBuilder.Entity<OrderItem>().HasKey(oi => oi.Id);

            modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Item)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ItemId);
        }
    }
}
