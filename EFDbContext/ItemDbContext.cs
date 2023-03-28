using Microsoft.EntityFrameworkCore;
using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.EFDbContext
{
    public class ItemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ItemDB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

}

