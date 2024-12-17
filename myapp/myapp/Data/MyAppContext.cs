using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using myapp.Models;

namespace myapp.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) { }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Use your actual connection string here
                optionsBuilder.UseSqlServer("Data Source=SAIF-AHMED\\SQL2022;Initial Catalog=myapp_database;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True");
            }
        }
    }
}


