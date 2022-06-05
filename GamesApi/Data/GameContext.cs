using GamesApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesApi.Data
{
    public class GameContext : DbContext
    {
        private string ConnectionString { get; set; }
        public GameContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public GameContext(DbContextOptions options) : base(options)
        {
        }

       
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConnectionString);
            }
            
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasIndex(g => new { g.Id, g.Name })
                .IsUnique();
        }
    }
}