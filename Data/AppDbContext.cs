using chat_sample.Models;
using Microsoft.EntityFrameworkCore;

namespace chat_sample.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Message> Messages { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
