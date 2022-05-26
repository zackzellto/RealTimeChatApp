using System;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Data
{
    public class ChatAppDataContext : DbContext
    {
        public ChatAppDataContext(DbContextOptions<ChatAppDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Messages>()
                .HasKey(c => new { c.Message, c.User, c.Time });
            modelBuilder.Entity<Users>()
                .HasKey(c => new { c.User });
        }



        public DbSet<Messages> Messages { get; set; }
        public DbSet<Users> Users { get; set; }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
